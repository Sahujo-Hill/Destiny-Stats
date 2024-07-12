using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Reflection.Metadata;
namespace DestinyProjectApp.Services
{
    public class DestinyApiHelper
    {
        private static readonly string BaseUrl = "https://www.bungie.net/platform/";
        private readonly HttpClient _httpClient;

        public DestinyApiHelper(string apiKey)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        }

        public async Task<string> SearchByGlobalNamePost(string globalname, int page)
        {
            var requestUrl = $"User/Search/GlobalName/{page}/";
            var content = new StringContent(JsonSerializer.Serialize(new { displayNamePrefix = globalname }), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl, content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException("Incorrect Search");
            }


        }

        public async Task<string> StatsSearch(long characterID, long membershipID, int membershipType)
        {
            var requesturl = $"Destiny2/{membershipType}/Account/{membershipID}/Character/{characterID}/Stats/";
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(requesturl);

            if (responseMessage.IsSuccessStatusCode)
            {
                return await responseMessage.Content.ReadAsStringAsync();
            }
            else
            {
                throw new HttpRequestException("Incorrect Search");
            }


        }

    }
}

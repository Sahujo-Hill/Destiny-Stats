using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Reflection.Metadata;
using DestinyProjectApp.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

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

        public async Task<long> SearchByGlobalNamePost(string globalname, int page)
        {
            var requestUrl = $"User/Search/GlobalName/{page}/";
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(new { displayNamePrefix = globalname }), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(requestUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);
                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {

                    var root = doc.RootElement;
                    if (root.TryGetProperty("Response", out var responseProperty) &&
                    responseProperty.TryGetProperty("searchResults", out var searchResultsProperty) &&
                    searchResultsProperty.GetArrayLength() > 0 &&
                    searchResultsProperty[0].TryGetProperty("destinyMemberships", out var destinyMembershipsProperty) &&
                     destinyMembershipsProperty.GetArrayLength() > 0 &&
                    destinyMembershipsProperty[0].TryGetProperty("membershipId", out var membershipIdProperty))
                    {
                        var membershipId = membershipIdProperty.GetString();
                        return long.Parse(membershipId);
                    }
                    else
                    {
                        throw new HttpRequestException("User not found!");
                    }

                }
            }
            else
            {
                throw new HttpRequestException("Incorrect Search");
            }
        }





        public async Task<Root> StatsSearch(long characterID, long membershipID, int membershipType)
        {
            var requesturl = $"Destiny2/{membershipType}/Account/{membershipID}/Character/{characterID}/Stats/";
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(requesturl);

            if (responseMessage.IsSuccessStatusCode)
            {
                
                var response = await responseMessage.Content.ReadAsStringAsync();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
                var result = JsonConvert.DeserializeObject<Response>(response);
                return myDeserializedClass;
            }
            else
            {
                throw new HttpRequestException("Incorrect Search");
            }


        }

        public class SearchResult
        {
            public long membershipid { get; set; }
        }
    }
}

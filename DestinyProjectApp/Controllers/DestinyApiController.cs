using DestinyProjectApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DestinyProjectApp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DestinyApiController : Controller
    {

        private readonly DestinyApiHelper destiny2ApiHelper;

        public DestinyApiController(DestinyApiHelper _destiny2ApiHelper)
        {
            destiny2ApiHelper = _destiny2ApiHelper;
        }

        //Get User Data By Username Destiny Api Controller

        [HttpPost("Search/GlobalName/{page}")]
        public async Task<IActionResult> GetDisplayName(string displayName, int page)
        {
            try
            {
                var getDisplayName = await destiny2ApiHelper.SearchByGlobalNamePost(displayName, page);
                return Ok(getDisplayName);
            }
            catch(HttpRequestException ex)
            {
                return StatusCode(500, "error");
            }
        }
    }
}
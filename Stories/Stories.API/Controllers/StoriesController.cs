using Microsoft.AspNetCore.Mvc;
using Stories.API.Models;
using System.Text.Json;

namespace Stories.API.Controllers
{
    [ApiController]
    [Route("api/stories")]
    public class StoriesController :ControllerBase
    {
        private readonly HttpClient _httpClient;
        public StoriesController()
        {
            _httpClient = new HttpClient();
        }


        [HttpGet("api/stories/detail")]
        public async Task<IActionResult> GetData([FromQuery] int n)
        {
            #region GetStories
            var apiUrl = "https://hacker-news.firebaseio.com/v0/beststories.json";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            #endregion
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                #region GetStories Details
                List<StoryDetail> Stories = new List<StoryDetail>();
                //int n = 3;

                string[] storyIDs = data.TrimStart('[').TrimEnd(']').Split(',');
                foreach (string id in storyIDs)
                {
                    var storyDetails = @"https://hacker-news.firebaseio.com/v0/item/" + id + ".json";
                    HttpResponseMessage detailRespoonse = await _httpClient.GetAsync(storyDetails);
                    string details = await detailRespoonse.Content.ReadAsStringAsync();
                    StoryDetail StoryDetail = JsonSerializer.Deserialize<StoryDetail>(details);
                    if (StoryDetail != null)
                    {
                        Stories.Add(StoryDetail);
                    }
                }
                return Ok(Stories.OrderByDescending(x => x.score).ToList().Take(n).ToArray<StoryDetail>());
                #endregion
              
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }

        }
    }
}

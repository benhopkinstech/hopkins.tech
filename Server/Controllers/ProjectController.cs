using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        [ResponseCache(Duration = 120)]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            IEnumerable<Project>? projects = Array.Empty<Project>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

                var result = await client.GetAsync("https://api.github.com/users/benhopkinstech/repos");

                if (result.IsSuccessStatusCode)
                {
                    using (var responseStream = await result.Content.ReadAsStreamAsync())
                    {
                        projects = await JsonSerializer.DeserializeAsync<IEnumerable<Project>>(responseStream);
                    }
                }
            }

            return projects ?? Array.Empty<Project>();
        }
    }
}

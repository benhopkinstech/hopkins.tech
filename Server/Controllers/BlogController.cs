using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BlogData> GetBlogPosts()
        {
            return new BlogData[] { new BlogData { Url = "test-title", Posted = DateTime.Now, Title = "Test Title", Summary = "This is a short summary for my test" } };
        }

        [HttpGet, Route("{url}")]
        public BlogData GetBlogPostByUrl(string url)
        {
            return new BlogData { Url = url, Posted = DateTime.Now, Title = "Test", Post = "<h1>Test</h1><h2>Testing</h2>This is the content of the blog post" };
        }
    }
}

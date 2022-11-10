using hopkins.tech.Server.Data;
using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ResponseCache(Duration = 120)]
    public class BlogController : ControllerBase
    {
        private readonly HopkinsTechContext _context;
        public BlogController(HopkinsTechContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<object> GetBlogPosts()
        {
            return _context.Blogs.Select(x => new { Id = x.Id, Url = x.Url, Posted = x.Posted, Title = x.Title, Summary = x.Summary });
        }

        [HttpGet, Route("{url}")]
        public object? GetBlogPostByUrl(string url)
        {
            var blogPost = _context.Blogs.Where(b => b.Url == url).FirstOrDefault();

            if(blogPost != null)
            {
                return new { Title = blogPost.Title, Posted = blogPost.Posted, Post = blogPost.Post };
            }

            return null;
        }

        [HttpPost]
        public IActionResult PostBlogData()
        {
            // Check url is unique

            return StatusCode(501);
        }

        [HttpPut]
        public IActionResult PutBlogData()
        {
            return StatusCode(501);
        }
    }
}

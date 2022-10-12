using hopkins.tech.Server.Data;
using hopkins.tech.Shared;
using Microsoft.AspNetCore.Mvc;

namespace hopkins.tech.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly HopkinsTechContext _context;
        public BlogController(HopkinsTechContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<BlogData> GetBlogPosts()
        {
            return _context.Blogs;
        }

        [HttpGet, Route("{url}")]
        public BlogData? GetBlogPostByUrl(string url)
        {
            return _context.Blogs.Where(b => b.Url == url).FirstOrDefault();
        }
    }
}

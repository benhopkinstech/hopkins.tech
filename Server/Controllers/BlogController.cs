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
            return _context.Blogs.Select(blog => new { blog.Id, blog.Url, blog.Posted, blog.Title, blog.Summary });
        }

        [HttpGet, Route("{url}")]
        public object? GetBlogPostByUrl(string url)
        {
            var blogPost = _context.Blogs.Where(b => b.Url == url).FirstOrDefault();

            if(blogPost != null)
            {
                return new { blogPost.Title, blogPost.Posted, blogPost.Post };
            }

            return null;
        }

        [HttpPost]
        public IActionResult PostBlogPost([FromBody] BlogData blogData)
        {
            if(_context.Blogs.Any(b => b.Url == blogData.Url))
            {
                return StatusCode(400);
            }

            _context.Blogs.Add(blogData);
            _context.SaveChanges();

            return StatusCode(201);
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace hopkins.tech.Shared
{
    public class BlogPostData
    {
        public string? Title { get; set; }
        public DateTime Posted { get; set; }
        public string? Post { get; set; }
    }
}
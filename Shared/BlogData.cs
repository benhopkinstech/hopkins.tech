using System.ComponentModel.DataAnnotations;

namespace hopkins.tech.Shared
{
    public class BlogData
    {
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public DateTime Posted { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Post { get; set; }
    }
}
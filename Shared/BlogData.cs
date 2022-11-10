using System.ComponentModel.DataAnnotations;

namespace hopkins.tech.Shared
{
    public class BlogData
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Url { get; set; }
        [Required]
        public DateTime Posted { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Summary { get; set; }
        [Required]
        public string? Post { get; set; }

        public BlogData()
        {
            Id = Guid.NewGuid();
            Posted = DateTime.Today;
        }
    }
}
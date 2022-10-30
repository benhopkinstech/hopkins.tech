using System.ComponentModel.DataAnnotations;

namespace hopkins.tech.Shared
{
    public class AboutData
    {
        public Guid Id { get; set; }
        public string? Summary { get; set; }
        public string? Education { get; set; }
        public string? Experience { get; set; }
    }
}
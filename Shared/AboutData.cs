using System.ComponentModel.DataAnnotations;

namespace hopkins.tech.Shared
{
    public class AboutData
    {
        public Guid Id { get; set; }
        public string? About { get; set; }
    }
}
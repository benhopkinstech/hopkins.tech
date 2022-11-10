using System.Text.Json.Serialization;

namespace hopkins.tech.Shared
{
    public class Project
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("stargazers_count")]
        public int Stars { get; set; }
        [JsonPropertyName("html_url")]
        public string? Link { get; set; }
    }
}

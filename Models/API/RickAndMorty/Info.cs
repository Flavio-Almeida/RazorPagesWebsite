using System.Text.Json.Serialization;

namespace RazorPagesWebsite.Models.API.RickAndMorty
{
    public class Info
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("pages")]
        public int Pages { get; set; }
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        [JsonPropertyName("prev")]
        public object? Prev { get; set; }
    }
}

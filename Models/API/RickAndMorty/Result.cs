using System.Text.Json.Serialization;

namespace RazorPagesWebsite.Models.API.RickAndMorty
{
    public class Result
    {
        [JsonPropertyName("id")]
        public required int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("species")]
        public string? Species { get; set; }

        [JsonPropertyName("gender")]
        public string? Gender { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

    }
}

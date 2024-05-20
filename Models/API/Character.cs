using System.Text.Json.Serialization;

namespace RazorPagesWebsite.Models.API
{
    public class Character
    {
        [JsonPropertyName("")]
        public required int Id { get; set; }

        [JsonPropertyName("")]
        public string? Name { get; set; }

        [JsonPropertyName("")]
        public string? Status { get; set; }

        [JsonPropertyName("")]
        public string? Species { get; set; }

        [JsonPropertyName("")]
        public string? Gender { get; set; }

        [JsonPropertyName("")]
        public string? Image { get; set; }

    }
}

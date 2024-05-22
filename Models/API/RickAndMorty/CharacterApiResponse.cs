using System.Text.Json.Serialization;

namespace RazorPagesWebsite.Models.API.RickAndMorty
{
    public class CharacterApiResponse
    {
        [JsonPropertyName("info")]
        public Info? Info { get; set; }
        [JsonPropertyName("results")]
        public Result[]? Results { get; set; }
    }
}

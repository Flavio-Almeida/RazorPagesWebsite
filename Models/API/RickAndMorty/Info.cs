using System.Text.Json.Serialization;

namespace RazorPagesWebsite.Models.API.RickAndMorty
{    
    public class Info
    {
        private const string _APIBaseUrl = "https://rickandmortyapi.com/api/character?page=";
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("pages")]
        public int Pages { get; set; }
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        public string NextPage
        {
            get
            {
                return (!String.IsNullOrEmpty(Next)) ? Next.Replace(_APIBaseUrl, "") : "";
            }
            set { }
        }
        [JsonPropertyName("prev")]
        public string? Prev { get; set; }
        public string PrevPage
        {
            get
            {
                return (!String.IsNullOrEmpty(Prev)) ? Prev.Replace(_APIBaseUrl, "") : "";
            }
            set { }
        }
    }
}

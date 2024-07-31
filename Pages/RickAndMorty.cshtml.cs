using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesWebsite.Models.API.RickAndMorty;
using RazorPagesWebsite.Utils;
using System.Text.Json;

namespace RazorPagesWebsite.Pages
{
    public class RickAndMortyModel : PageModel
    {
        public CharacterApiResponse? Characters { get; set; }

        public async Task OnGet(string? pageNo)
        {
            var simpleGetRequest = new SimpleGetRequest();
            
            string pagination = (!string.IsNullOrEmpty(pageNo)) ? $"?page={pageNo}" : "";

            var responseString = await simpleGetRequest.Get($"https://rickandmortyapi.com/api/character{pagination}");


            Characters = JsonSerializer.Deserialize<CharacterApiResponse>(responseString)!;            
        }
    }
}

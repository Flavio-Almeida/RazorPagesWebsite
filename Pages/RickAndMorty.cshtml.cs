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

        public async Task OnGet(string? pageNo = "1")
        {
            var simpleGetRequest = new SimpleGetRequest();
            
            string pagination = (!string.IsNullOrEmpty(pageNo)) ? $"?page={pageNo}" : "";

            var responseString = await simpleGetRequest.Get($"https://rickandmortyapi.com/api/character{pagination}");
            
            if (string.IsNullOrEmpty(responseString) )
            {
                responseString = await simpleGetRequest.Get($"https://rickandmortyapi.com/api/character?page=1", 2);
            }

            Characters = JsonSerializer.Deserialize<CharacterApiResponse>(responseString)!;            
        }
    }
}

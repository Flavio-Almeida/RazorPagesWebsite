using System.Collections;
using System.Text.Json;

namespace RazorPagesWebsite.Utils
{
    public class SimpleGetRequest
    {
        public async Task<string> Get(string endPointUrl, int? attempt=1)
        {
            using HttpClient client = new();
            try
            {
                string response = await client.GetStringAsync(endPointUrl);
                return response;
            }
            catch (HttpRequestException ex)
            {
                if (attempt == 1)
                {
                    return null;
                }
                else
                {
                    throw new HttpRequestException($"API request error founded : {ex.Message}", ex.InnerException);
                } 
            }            
            catch (Exception ex)
            {
                throw new Exception($"An error occured: {ex.Message}", ex.InnerException);
            }
        }
    }
}

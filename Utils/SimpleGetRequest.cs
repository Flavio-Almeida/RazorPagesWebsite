using System.Collections;
using System.Text.Json;

namespace RazorPagesWebsite.Utils
{
    public class SimpleGetRequest
    {
        public async Task<string> Get(string endPointUrl)
        {
            using HttpClient client = new();
            try
            {
                string response = await client.GetStringAsync(endPointUrl);
                return response;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException("API request error founded : ", ex.InnerException);
            }
        }
    }
}

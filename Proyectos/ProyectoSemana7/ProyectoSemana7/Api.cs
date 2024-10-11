using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{
    private readonly string apiUrl;

    public ApiClient(string url)
    {
        apiUrl = url;
    }

    public async Task<string> FetchJokeAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            return await client.GetStringAsync(apiUrl);
        }
    }
}

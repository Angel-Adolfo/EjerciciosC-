using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoSemana6.Models;

public class JokeManager
{
    private readonly ApiClient apiClient;
    private readonly FileHandler fileHandler;

    public JokeManager(string apiUrl, string filePath)
    {
        apiClient = new ApiClient(apiUrl);
        fileHandler = new FileHandler(filePath);
    }

    public async Task<Joke> GetJokeAsync()
    {
        var jokeContent = await apiClient.FetchJokeAsync();
        return new Joke(ExtractJoke(jokeContent));
    }

    public void SaveJoke(Joke joke)
    {
        var jokes = fileHandler.ReadJokes();
        if (!jokes.Contains(joke.Content))
        {
            fileHandler.WriteJoke(joke.Content);
        }
    }

    public List<Joke> SearchJokes(string keyword)
    {
        var jokes = fileHandler.ReadJokes();
        return jokes
            .Where(joke => joke.IndexOf(keyword, System.StringComparison.OrdinalIgnoreCase) >= 0)
            .Select(joke => new Joke(joke))
            .ToList();
    }

    private string ExtractJoke(string jsonResponse)
    {
        var startIndex = jsonResponse.IndexOf("\"value\":\"") + 9;
        var endIndex = jsonResponse.IndexOf("\"", startIndex);
        return jsonResponse.Substring(startIndex, endIndex - startIndex);
    }
}


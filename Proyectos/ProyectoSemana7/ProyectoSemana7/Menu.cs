using System;
using System.Threading.Tasks;

public class Menu
{
    private JokeManager jokeManager = new JokeManager("https://api.chucknorris.io/jokes/random", "jokes.txt");

    private const int GetNewJokeOption = 1;
    private const int SearchJokesOption = 2;
    private const int ExitOption = 3;

    public async Task DisplayMenuAsync()
    {
        int option;
        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine($"{GetNewJokeOption}. Obtener un nuevo chiste");
            Console.WriteLine($"{SearchJokesOption}. Buscar chistes por palabra clave");
            Console.WriteLine($"{ExitOption}. Salir");
            Console.Write("Ingrese una opción: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case GetNewJokeOption:
                    await GetNewJokeAsync();
                    break;
                case SearchJokesOption:
                    SearchJokes();
                    break;
                case ExitOption:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (option != ExitOption);
    }

    private async Task GetNewJokeAsync()
    {
        var joke = await jokeManager.GetJokeAsync();
        jokeManager.SaveJoke(joke);
        Console.WriteLine("Nuevo chiste guardado: " + joke);
    }

    private void SearchJokes()
    {
        Console.Write("Ingrese la palabra clave para buscar: ");
        string keyword = Console.ReadLine();
        var jokes = jokeManager.SearchJokes(keyword);

        if (jokes.Count == 0)
        {
            Console.WriteLine("No se encontraron chistes con la palabra clave.");
        }
        else
        {
            Console.WriteLine("Chistes encontrados:");
            foreach (var joke in jokes)
            {
                Console.WriteLine(joke);
            }
        }
    }
}

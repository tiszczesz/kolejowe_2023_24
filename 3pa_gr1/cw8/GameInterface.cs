namespace cw8;

public class GameInterface
{
    public static Game CreateGame()
    {
        Console.WriteLine("Dodawanie nowej gry");
        Console.Write("Podaj tytul gry: ");
        var title = Console.ReadLine()?.Trim();
        Console.Write("Podaj rodzaj gry: ");
        var genre = Console.ReadLine()?.Trim();
        Console.Write("Podaj rok powstania gry: ");
        var year = Convert.ToInt32(Console.ReadLine()?.Trim());
        Console.Write("Podaj cene gry: ");
        var price = Convert.ToDecimal(Console.ReadLine()?.Trim());
        return new Game
        {
            Id = -1,
            Title = title,
            Genre = genre,
            Year = year,
            Price = price            
        };

    }
    public static void ShowAll(List<Game> games){
        foreach(var g in games){
            ShowGame(g);
        }
    }
    public static void ShowGame(Game g){
        Console.WriteLine("Tytul: "+g.Title);
        Console.WriteLine("Rodzaj: "+g.Genre);
        Console.WriteLine("Rok produkcji: "+g.Year);
        Console.WriteLine("Cena: "+g.Price+ " PLN");
    }
    public static Game? GetGameByTitle(List<Game> games){
        Console.Write("Podaj tytul gry: ");
        string? title = Console.ReadLine()?.Trim();
        return games.Find((g)=>{return g.Title!.ToLower()
           .Contains(title?.ToLower() ?? "null");});
    }
}

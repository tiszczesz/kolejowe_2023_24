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
}

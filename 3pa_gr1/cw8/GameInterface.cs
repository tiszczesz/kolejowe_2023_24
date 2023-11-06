namespace cw8;

public class GameInterface
{
    public static Game CreateGame(){
        Console.WriteLine("Dodawanie nowej gry");
        Console.Write("Podaj tytul gry: ");
        var title = Console.ReadLine()?.Trim();


        return new Game{
            Id = -1,
            Title = title,
            //.....
        };

    }
}

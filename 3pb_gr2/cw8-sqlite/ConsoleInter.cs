
namespace cw8_sqlite;

public class ConsoleInter
{
    public static void ShowAllPosts(List<Post> posts){
        Console.WriteLine(" Informacje o postach: "+posts.Count);
        foreach(var p in posts){
            ShowPost(p);
        }
    }

    public static void ShowPost(Post p)
    {
        Console.WriteLine("\n ===== Informacje o poscie ======");
        Console.WriteLine($" Tytul postu: {p.Title}  ");
        Console.WriteLine($" Tresc postu: {p.Content}  ");
        Console.WriteLine($" Data utworzenia: {p.PostDate.ToShortDateString()}  ");

    }
    public static Post CreatePost(){
        Console.WriteLine(" === Podaj informacje o poscie");
        Console.Write(" Tytul postu: ");
        string? title = Console.ReadLine()?.Trim();
        Console.Write(" Tresc postu: ");
        string? content = Console.ReadLine()?.Trim();
        return new Post{
            Id = -1,
            Title = title,
            Content = content,
            PostDate = DateTime.Now
        };
    }
    public static List<Post>? SearchPostsByTitle(List<Post> posts){
        Console.Write("\n\tPodaj tytul posta do wyszukania: ");
        string? title = Console.ReadLine()?.Trim()?.ToLower();
        if(title==null) return null;
        Console.WriteLine(title);
        return posts.Where(p=>p.Title!.ToLower().Contains(title)).ToList();
    }
}


namespace cw9_sqlite;

public class PostsInterface
{
    public static void ShowPosts(List<Post> posts){
        Console.WriteLine($"Ilosc postow: {posts.Count}");
        foreach(var p in posts){
            ShowPost(p);
        }
    }

    public static void ShowPost(Post p)
    {
       Console.WriteLine("Tytul postu: "+p.Title);
       Console.WriteLine("Tresc postu: "+p.Content);
       Console.WriteLine("Data postu: "+p.CreateDate?.ToShortDateString());
       Console.WriteLine(" =========================================  ");

    }
    public static Post NewPost(){
        Console.WriteLine("Informacje o poscie ---");
        Console.Write("Podaj tytul postu: ");
        string? title = Console.ReadLine()?.Trim();
        Console.Write("Podaj zawartosc postu: ");
        string? content = Console.ReadLine()?.Trim();
        return new Post{
            Id = -1,
            Title = title,
            Content = content,
            CreateDate = DateTime.Now
        };
    }
}


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
}

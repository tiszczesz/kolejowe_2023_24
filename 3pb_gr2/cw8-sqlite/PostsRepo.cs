using Microsoft.Data.Sqlite;

namespace cw8_sqlite;

public class PostsRepo
{
    private string connString;
    public PostsRepo()
    {
        string path = AppContext.BaseDirectory;
        connString = "Data Source="+System.IO.Path.Join(path,"dane.db");
    }
    public List<Post> GetPosts(){
        List<Post> posts = new List<Post>();
        SqliteConnection conn = new SqliteConnection(connString);
        SqliteCommand command = conn.CreateCommand();
       // SqliteCommand command1 = new SqliteCommand("sql",conn);
        command.CommandText = "SELECT * FROM Posts";        
        conn.Open();
        SqliteDataReader rd = command.ExecuteReader();
        if(rd.HasRows){
            while(rd.Read()){
                posts.Add(
                    new Post{
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Content = rd.GetString(2),
                        PostDate = rd.GetDateTime(3)
                    }
                );
            }
        }
        conn.Close();
        return posts;
    }
}

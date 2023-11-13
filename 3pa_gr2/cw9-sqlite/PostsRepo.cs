using Microsoft.Data.Sqlite;

namespace cw9_sqlite;

public class PostsRepo
{
    private string connString;
    public PostsRepo()
    {
        string path = AppContext.BaseDirectory;
        connString = "Data Source="+System.IO.Path.Join(path,"data.db");
    }
    public List<Post> GetPosts(){
        List<Post> posts = new List<Post>();
        SqliteConnection conn = new SqliteConnection(connString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM Posts";
        conn.Open();
        SqliteDataReader rd = command.ExecuteReader();
        if(rd.HasRows){
            while(rd.Read()){
                posts.Add(new Post{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Content = rd.GetString(2),
                    CreateDate = rd.GetDateTime(3)
                });
            }
        }
        
        conn.Close(); 
        return posts;
    }
}

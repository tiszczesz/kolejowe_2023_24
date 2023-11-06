using Microsoft.Data.Sqlite;

namespace cw9_sqlite;

public class PostsRepo
{
    private string connString;
    public PostsRepo()
    {
        connString = "Data Source=data.db";
    }
    public List<Post> GetPosts(){
        List<Post> posts = new List<Post>();
        SqliteConnection conn = new SqliteConnection(connString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM Posts";
        SqliteDataReader rd = command.ExecuteReader();
        if(rd.HasRows){
            while(rd.Read()){
                posts.Add(new Post{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Conent = rd.GetString(3),
                    
                });
            }
        }
        conn.Open();



        conn.Close(); 
        return posts;
    }
}

using Microsoft.Data.Sqlite;

namespace web1;

public class RepoTodos
{
    private string? _connString;
    public RepoTodos(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("sqliteconn");
    }
    public List<Todo> GetTodos()
    {
        List<Todo> todos = new();
        SqliteConnection connection = new SqliteConnection(_connString);
        string sql = "SELECT id,content,date FROM todos";
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = sql;
        connection.Open();
        SqliteDataReader rd = command.ExecuteReader();
        if (rd.HasRows)
        {
            while (rd.Read())
            {
                todos.Add(new Todo
                {
                    Id = rd.GetInt32(0),
                    Content = rd.GetString(1),
                    Date = DateOnly.FromDateTime(rd.GetDateTime(2))
                });
            }
        }
        connection.Close();
        return todos;
    }
}

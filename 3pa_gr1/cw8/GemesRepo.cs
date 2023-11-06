using Microsoft.Data.Sqlite;

namespace cw8;

public class GamesRepo
{
    private string connString;
    public GamesRepo()
    {
        string path = AppContext.BaseDirectory;
        Console.WriteLine(path);

        connString = "Data Source="+System.IO.Path.Join(path,"dane.db");
    }
    public List<Game> GetGames()
    {
        List<Game> games = new List<Game>();
        SqliteConnection connection = new SqliteConnection(connString);
        SqliteCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Id,Title,Genre,Year,Price FROM Games";
        connection.Open();

        SqliteDataReader rd = command.ExecuteReader();
        if (rd.HasRows)
        {
            while (rd.Read())
            {
                games.Add(
                    new Game
                    {
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Genre = rd.GetString(2),
                        Year = rd.GetInt32(3),
                        Price = rd.GetDecimal(4)
                    }
                );
            }
        }
        connection.Close();
        return games;
    }
    public void InsertGame(Game g){
        //zapis do bazy
    }
}

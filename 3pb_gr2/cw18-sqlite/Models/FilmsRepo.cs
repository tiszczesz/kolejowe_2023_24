using Microsoft.Data.Sqlite;

namespace cw18_sqlite.Models;

public class FilmsRepo
{
    private readonly string _connString;
    public FilmsRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("sqlite") 
           ?? "Data Source=DbFilms.db";
    }
    public List<MyFilm> GetAllFilms(){
        List<MyFilm> films = new();
        using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Films";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read()){
                films.Add( new MyFilm{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Director = rd.GetString(2),
                    Language = rd.GetString(3),
                    Date = rd.GetString(4),
                    Price = rd.GetDecimal(5)
                });
            }
        }
        return films;
    }
}

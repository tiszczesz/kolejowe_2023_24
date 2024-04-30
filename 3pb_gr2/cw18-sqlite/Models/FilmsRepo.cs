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

    public void Delete(int? id)
    {
        
         using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = $"DELETE FROM Films WHERE Id={id}";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }

    public void InsertFilm(MyFilm film)
    {
        using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = $"INSERT INTO Films(Title,Director,Language,Date,Price) "+
            $"VALUES(@Title,@Director,@Language,@Date,@Price)";
            command.Parameters.AddWithValue("@Title", film.Title);
            command.Parameters.AddWithValue("@Director", film.Director);
            command.Parameters.AddWithValue("@Language", film.Language);
            command.Parameters.AddWithValue("@Date", film.Date);
            command.Parameters.AddWithValue("@Price", film.Price);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            
        }
    }

    public  MyFilm? GetById(int? id)
    {
        using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT * FROM Films WHERE Id={id}";
            conn.Open();
            SqliteDataReader rd =  command.ExecuteReader();
            rd.Read();
            var result = new MyFilm{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Director = rd.GetString(2),
                    Language = rd.GetString(3),
                    Date = rd.GetString(4),
                    Price = rd.GetDecimal(5)
                };
            return result;
        }
    }

    public void UpdateFilm(MyFilm? film)
    {
        if(film==null) return;
         using (SqliteConnection conn = new SqliteConnection(_connString))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = $"UPDATE Films SET Title=@Title,Director=@Director,Language=@Language,Date=@Date,Price=@Price "+
            $" WHERE Id=@Id";
            command.Parameters.AddWithValue("@Title", film.Title);
            command.Parameters.AddWithValue("@Director", film.Director);
            command.Parameters.AddWithValue("@Language", film.Language);
            command.Parameters.AddWithValue("@Date", film.Date);
            command.Parameters.AddWithValue("@Price", film.Price);
            command.Parameters.AddWithValue("@Id", film.Id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            
        }
    }
}

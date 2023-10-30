using System.Globalization;
using Microsoft.Data.Sqlite;

namespace cc4_sqlite;

public class FilmRepo
{
    private string connString = "Data Source=dane.db";
    public FilmRepo()
    {
        
    }
    public List<Film> GetFilms(){
        List<Film> films = new List<Film>();
        using(SqliteConnection conn = new SqliteConnection(connString)){
            string sqlSelect = "SELECT * FROM films";
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = sqlSelect;
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            if(rd.HasRows){
                while(rd.Read()){
                    films.Add( new Film{
                        Id = rd.GetInt32(0),
                        Title = rd.GetString(1),
                        Price = rd.GetDecimal(2),
                        Genre = rd.GetString(3)
                    });
                }
            } 
            
        }

        return films;
    }

    public void AddFilm(Film film)
    {
        using(SqliteConnection conn = new SqliteConnection(connString)){
            conn.Open();
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO films(title,price,genre) VALUES(@Title,@Price,@Genre)";
        
            command.Parameters.AddWithValue("@Title",film.Title);
            command.Parameters.AddWithValue("@Price",film.Price.ToString(CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@Genre",film.Genre);
            
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

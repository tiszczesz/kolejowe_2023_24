using System.Globalization;
using cw18_sqlite.Models;
using Microsoft.Data.Sqlite;

namespace cw18_sqlite;

public class BookRepo
{
    private string _connection;
    public BookRepo(IConfiguration configuration)
    {
        _connection = configuration.GetConnectionString("sqlite")
           ?? "Data Source=Books.db";
    }
    public List<Book> GetBooks(){
        List<Book> books = new List<Book>();
        using (SqliteConnection conn = new SqliteConnection(_connection))
        {
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM books";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read()){
                books.Add(new Book{
                    Id = rd.GetInt32(0),
                    Title = rd.GetString(1),
                    Author = rd.GetString(2),
                    Price = rd.GetDecimal(3)
                });
            }
            conn.Close();
        }

        return books;
    }

    internal void InsertBook(Book book)
    {
        using(SqliteConnection conn = new SqliteConnection(_connection)){
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO books(title,author,price) "+
              $" VALUES('{book?.Title?.Trim()}','{book?.Author?.Trim()}',{book?.Price?.ToString(CultureInfo.InvariantCulture)})";
              conn.Open();
              command.ExecuteNonQuery();
              conn.Close();
        }
    }
}

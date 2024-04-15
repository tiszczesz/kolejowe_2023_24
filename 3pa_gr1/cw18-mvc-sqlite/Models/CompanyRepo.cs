using Microsoft.Data.Sqlite;

namespace cw18_mvc_sqlite.Models;

public class CompanyRepo
{
    private string _connString;
    public CompanyRepo(IConfiguration configuration){
        _connString = configuration.GetConnectionString("sqlite")
         ?? "Data Source=myCompany.db";
    }

    public List<Company> GetAll(){
        List<Company> companies = new List<Company>();
        using(SqliteConnection conn = new SqliteConnection(_connString)){
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Clients";
            conn.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while(rd.Read()){
                companies.Add(new Company{
                    Id = rd.GetInt32(0),
                    Firstname = rd.GetString(1),
                    Lastname = rd.GetString(2),
                    Price = rd.GetDecimal(3)
                });
            }
            conn.Close();
        }
        return companies;
    }
}

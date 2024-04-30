using Microsoft.Data.Sqlite;

namespace cw18_sqlite.Models;

public class CarsRepo
{
    private string _connString;
    public CarsRepo(IConfiguration configuration){
        _connString = configuration.GetConnectionString("sqlite")
           ?? "Data Source=Cars.db";
    }
    public List<Car> GetCars(string? fieldName=null){
        List<Car> cars = new();
        using (SqliteConnection connection = new SqliteConnection(_connString))
        {
            SqliteCommand command = connection.CreateCommand();
            string orderby = fieldName!=null? " order by "+fieldName: "";
            command.CommandText = "SELECT * FROM MyCars "+orderby;
            connection.Open();
            SqliteDataReader rd = command.ExecuteReader();
            while (rd.Read()){
                cars.Add(
                    new Car{
                        Id = rd.GetInt32(0),
                        Model = rd.GetString(1),
                        Year = rd.GetInt32(2),
                        Price = rd.GetInt32(3)
                    }
                );
            }
        }
        return cars;
    }

    internal void InsertCar(Car car)
    {
       using(SqliteConnection conn = new SqliteConnection(_connString)){
        SqliteCommand command = conn.CreateCommand();
        command.CommandText=
        $"INSERT INTO MyCars(model,year,price) VALUES('{car.Model}',{car.Year},{car.Price})";
        conn.Open();
        command.ExecuteNonQuery();
        conn.Close();
       }
    }

    public Car? GetCarById(int? id) {
        Car car;
        using (SqliteConnection connection = new SqliteConnection(_connString))
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM MyCars WHERE id={id}";
            connection.Open();
            SqliteDataReader rd = command.ExecuteReader();

            rd.Read();
            car = new Car {
                Id = rd.GetInt32(0),
                Model = rd.GetString(1),
                Year = rd.GetInt32(2),
                Price = rd.GetInt32(3)
            };

        }

        return car;

    }

    public void DeleteCar(int? id)
    {
        if(id==null) return;
        using (SqliteConnection connection = new SqliteConnection(_connString)){
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM MyCars WHERE id={id}";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void UpdateCar(Car car){
         using (SqliteConnection connection = new SqliteConnection(_connString)){
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE MyCars SET model='{car.Model}',year={car.Year},price={car.Price}  WHERE id={car.Id}";
            Console.WriteLine(command.CommandText);
           connection.Open();
           command.ExecuteNonQuery();
           connection.Close();
        }
    }
}

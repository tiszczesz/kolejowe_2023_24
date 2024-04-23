using Microsoft.Data.Sqlite;

namespace cw18_sqlite.Models;

public class CarsRepo
{
    private string _connString;
    public CarsRepo(IConfiguration configuration){
        _connString = configuration.GetConnectionString("sqlite")
           ?? "Data Source=Cars.db";
    }
    public List<Car> GetCars(){
        List<Car> cars = new();
        using (SqliteConnection connection = new SqliteConnection(_connString))
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM MyCars";
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
}

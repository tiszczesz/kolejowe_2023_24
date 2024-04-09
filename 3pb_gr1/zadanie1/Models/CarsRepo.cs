
using System.Text.Json;

namespace zadanie1.Models;

public class CarsRepo
{
    public List<Car>? Cars { get; set; }
    public CarsRepo()
    {
        Cars = getCars("cars.json");
    }

    private List<Car>? getCars(string filename)
    {
        string data = File.ReadAllText(filename);
        return JsonSerializer.Deserialize<List<Car>>(data);
    }
}

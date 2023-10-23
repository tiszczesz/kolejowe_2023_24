using Microsoft.VisualBasic;

namespace cw8;

public class Testowa
{
    public int Id { get; set; } = 1;
    public string? Name { get; set; } = "Name";
    public DateTime DateOf { get; set; } = DateTime.Now;
    public string Serialize()
    {
        return $"{Id};{Name};{DateOf}";
    }
    public static Testowa? Deserialize(string data)
    {
        var dd = data.Split(';');
        var DateAndTime = dd[2].Split(' ');
        var onlyDate = DateAndTime[0].Split(':');
        DateTime toSerialize =
        new DateTime(Convert.ToInt32(onlyDate[2]),
        Convert.ToInt32(onlyDate[1]),
        Convert.ToInt32(onlyDate[0]));
        if (dd.Length != 3) return null;
        return new Testowa
        {
            Id = Convert.ToInt32(dd[0]),
            Name = dd[1],
            DateOf = toSerialize
        };
    }
}

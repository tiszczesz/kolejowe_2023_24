namespace cw8;

public class Fake
{
    public int Id { get; set; }
    public string? Name { get; set; }    
    public decimal Price { get; set; }
    public string SerializeToCSV(){
        return $"{Id};{Name};{Price}\n";
    }
    public static Fake? DeserializeFromCSV(string line){
        var data = line.Split(';');
        if(data.Length!=3) return null;
        try{
            return new Fake{
            Id = Convert.ToInt32(data[0]),
            Name = data[1],
            Price = Convert.ToDecimal(data[2])
        };
        }catch(FormatException ex){
            return null;
        }        
    }
}

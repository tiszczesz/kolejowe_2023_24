namespace cw10_empty;

public class ProductRepo
{
    public static List<Product> GetProducts(){
        return new List<Product>{
            new Product{Id=1,Name="Gruszki",Price=23.6m},
            new Product{Id=2,Name="Pietruszki",Price=13.6m,ProdDate=new DateTime(2023,10,12)},
            new Product{Id=3,Name="Marchewki",Price=9.6m},
            new Product{Id=4,Name="Jabłka",Price=14.9m,ProdDate=new DateTime(2023,9,28)},
            new Product{Id=5,Name="Śliwki",Price=24m}
        };
    }
}

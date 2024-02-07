namespace cw12_empty;

public class GiftRepo
{
    public static List<Gift> GetGifts()
    {
        return new List<Gift>{
            new Gift{Name="Konik na biegunach",Price=23.90m,Owner="Jasiu"},
            new Gift{Name="Lalka Barbie",Price=123.90m,Owner="Ania"},
            new Gift{Name="Klocki LEGO",Price=77.90m,Owner="Tomaszek"},
            new Gift{Name="Książka Kucharska",Price=34.90m,Owner="Mamusia"},
            new Gift{Name="Skarpetki",Price=13.90m,Owner="Tatuś"},
        };
    }
}

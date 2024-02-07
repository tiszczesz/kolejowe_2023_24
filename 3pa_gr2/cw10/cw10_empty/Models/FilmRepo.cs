namespace cw10_empty;

public class FilmRepo
{
    public static List<Film> GetFilms()
    {
        return new List<Film>{
            new Film{Id=1,Title="Film1",Length=100},
            new Film{Id=2,Title="Film2",Length=67},
            new Film{Id=3,Title="Film3",Length=89
                       ,CreateDate=new DateTime(2022,3,12)},
            new Film{Id=4,Title="Film4",Length=120},
            new Film{Id=5,Title="Film5",Length=90},
            new Film{Id=6,Title="Film6",Length=78},
        };
    }
}

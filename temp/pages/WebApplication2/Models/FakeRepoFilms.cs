namespace WebApplication2.Models; 

public class FakeRepoFilms :IRepoFilms {
    public List<Film> GetFilms() {
        return new List<Film> {
            new Film {
                Id = 1, Title = "film1", Author = "Adam Nowak",
                RealizeDate = new DateTime(2009, 12, 23)
            },
            new Film {
                Id = 2, Title = "film2", Author = "Anna Nowak",
                RealizeDate = new DateTime(2003, 12, 23)
            },
            new Film {
                Id = 3, Title = "film3", Author = "Reante Nowak",
                RealizeDate = new DateTime(2012, 12, 23)
            },
            new Film {
                Id = 4, Title = "film4", Author = "Tomasz Bomasz",
                RealizeDate = new DateTime(2013, 3, 12)
            },
            new Film {
                Id = 5, Title = "film5", Author = "Adam Nowak",
                RealizeDate = new DateTime(2009, 8, 9)
            },
        };
    }
}
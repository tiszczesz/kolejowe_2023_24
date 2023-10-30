using System.Security.Cryptography.X509Certificates;
using cc4_sqlite;

FilmRepo repo = new FilmRepo();

var films = repo.GetFilms();
Console.WriteLine(films.Count);
AddFilmInput();
films = repo.GetFilms();
Console.WriteLine(films.Count);


////////////////////////////////
void AddFilmInput()
{
    Console.WriteLine(" =======  DODAWANIE FILMU =========\n");
    Console.Write("\t podaj tytul: ");
    string? title = Console.ReadLine();
    Console.Write("\t podaj cene: ");
    string? priceString = Console.ReadLine();
    decimal price = Convert.ToDecimal(priceString);
    Console.Write("\t podaj rodzaj: ");
    string? genre = Console.ReadLine();
    var film = new Film{Id=-1,Title=title,Price=price,Genre=genre};
    repo.AddFilm(film);

}
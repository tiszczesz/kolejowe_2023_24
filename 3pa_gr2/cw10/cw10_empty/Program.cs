using cw10_empty;

var builder = WebApplication.CreateBuilder(args);
//dodawanie funkcjonalnosci

var app = builder.Build();
// uzywanie funkcjonalnosci
app.UseStaticFiles();
string name = "Xawery";
int age = 22;
var films = FilmRepo.GetFilms();
app.MapGet("/", () => "Hello World!");
app.MapGet("/page1", () => "Witam na stronie pierwszej");
app.MapGet("/person", () => $"Witam {name} twój wiek: {age}");
app.MapGet("/date", () => $"Dzisiaj mamy: {DateTime.Now.ToShortDateString()}");
app.MapGet("/films", () => films);

app.Run();

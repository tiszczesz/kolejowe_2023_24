using cw9_empty;

var builder = WebApplication.CreateBuilder(args);
//1 czesc dodawanie

var app = builder.Build();
//2 czesc uzywanie
app.UseStaticFiles();
string name = "Franek";


app.MapGet("/", () => "<h1>Hello World!</h1>");
app.MapGet("/s1", () => "To jest s1");
app.MapGet("/hello", () =>
        $"Witaj {name} dzisiaj mamy: {DateTime.Now.ToShortDateString()}");
app.MapGet("/hello2",()=>$"Imię Nazwisko klasa aktualny rok: {DateTime.Now.Year} ");
app.MapGet("/students",()=>StudentRepo.GetStudents());
app.MapGet("/primes",()=>Primes.GetPrimes(30));
app.Run();

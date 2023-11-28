using cw9_empty;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string name = "Franek";


app.MapGet("/", () => "Hello World!");
app.MapGet("/s1", () => "To jest s1");
app.MapGet("/hello", () =>
        $"Witaj {name} dzisiaj mamy: {DateTime.Now.ToShortDateString()}");
app.MapGet("/hello2",()=>$"Imię Nazwisko klasa aktualny rok: {DateTime.Now.Year} ");
app.MapGet("/students",()=>StudentRepo.GetStudents());
app.Run();

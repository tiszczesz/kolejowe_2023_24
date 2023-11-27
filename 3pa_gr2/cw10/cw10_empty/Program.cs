var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string name = "Xawery";
int age = 22;

app.MapGet("/", () => "Hello World!");
app.MapGet("/page1", () => "Witam na stronie pierwszej");
app.MapGet("/person", () => $"Witam {name} twój wiek: {age}");
app.MapGet("/date", () => $"Dzisiaj mamy: {DateTime.Now.ToShortDateString()}");

app.Run();

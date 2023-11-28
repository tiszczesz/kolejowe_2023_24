using cw10_empty;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string firstname = "Tomasz";
int age = 34;

app.MapGet("/", () => "Hello World!");
app.MapGet("/p1", () => "Witaj ze strony p1");
app.MapGet("/p2", () =>
 $"Witaj {firstname} twój wiek: {age} Dzisiaj mamy: {DateTime.Now.ToShortDateString()}");
app.MapGet("/products",()=>ProductRepo.GetProducts());

app.Run();

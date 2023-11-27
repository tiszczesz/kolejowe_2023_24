using cw9_empty;
var builder = WebApplication.CreateBuilder(args);
//wstrzykiwanie funkcjonalnosci

var app = builder.Build();
//używanie wstrzyknietych funkcjonalnosci
app.UseStaticFiles();

string firstname = "Szymon";
string lastname = "Małecki";
var students = StudentsRepo.GetStudents();
app.MapGet("/", () => "Hello World!");
app.MapGet("/s1", () => "Witaj ze strony s1");
app.MapGet("/s2", () => $"Witaj {firstname} {lastname}");
app.MapGet("/students", () => students);

app.Run();

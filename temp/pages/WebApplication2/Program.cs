using System.Text;
using System.Text.Json;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();
 app.MapGet("/", () => {
     Numbers numbers = new Numbers();
     StringBuilder sb = new StringBuilder();
     foreach (var number in numbers.GetRandomNumbers(20)) {
         sb.Append(number.ToString()).Append(" ");
     }
     return sb.ToString();
 });
 app.MapGet("/api/films", () => {
     IRepoFilms repo = new FakeRepoFilms();
     var films = repo.GetFilms();
     return JsonSerializer.Serialize(films);
 });

app.Run();

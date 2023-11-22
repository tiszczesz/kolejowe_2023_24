using System.Text;
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
// app.MapGet("/api", () => "API");

app.Run();

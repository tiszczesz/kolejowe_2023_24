var builder = WebApplication.CreateBuilder(args);
//dodawanie funkcjonalnosci
builder.Services.AddRazorPages();

var app = builder.Build();
//uzywanie funkcjonbalnosci
app.UseStaticFiles();
app.MapRazorPages();  

app.Run();

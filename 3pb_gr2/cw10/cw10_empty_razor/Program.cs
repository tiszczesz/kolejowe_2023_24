var builder = WebApplication.CreateBuilder(args);
//dodawanie funkcjonalnosci
builder.Services.AddRazorPages();

var app = builder.Build();
// uzywanie funkcjonalnosci

// app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapRazorPages();

app.Run();

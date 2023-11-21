var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/api", () => "API");

app.Run();

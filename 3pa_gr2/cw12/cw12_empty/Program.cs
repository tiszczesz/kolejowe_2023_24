var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
//app.MapGet("/", () => "Hello World!");

app.Run();

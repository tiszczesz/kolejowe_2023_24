using api;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.GetConnectionString("sqliteconn");
var db = new RepoTodos(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () =>  "Hello world");
app.MapGet("/todos", () => Results.Ok(db.GetTodos()));
app.MapGet("/todos/{id}", (int? id) => {
    var result = db.GetById(id);
    return result!=null ?Results.Ok(result):Results.NotFound();
});

app.MapPost("/todos/",(Todo todo)=>{
    var result = db.SaveTodo(todo);
    return result==1? Results.Ok(todo) : Results.NotFound();
});
app.MapDelete("/todos/{id}",(int? id)=>{
    var result = db.DeleteTodo(id);
    return result==1 ? Results.Ok() : Results.NotFound();
});

app.Run();

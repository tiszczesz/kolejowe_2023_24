### Utworzenie aplikacji web empty
```console
dotnet new web -o nazwa-aplikacji
```

### Utworzenie katalogów wwwroot Pages Models

### Utworzenie pliku nazwaBazy.db
### Przy użyciu wtyczki Sqlite Explorer
Utworzenie bazy zanych oraz wstawienie rekordów po otwarciu połączenia z plikiem nazwaBazy.db

```sql
-- SQLite
CREATE TABLE todos(
    id INTEGER PRIMARY KEY,
    content TEXT,
    date TEXT
);
INSERT INTO todos(content,date)
VALUES('zadanie 1' ,'2018-04-02');
INSERT INTO todos(content,date)
VALUES('zadanie 2' ,'2024-11-23');
INSERT INTO todos(content,date)
VALUES('zadanie 3' ,'2019-09-09');
INSERT INTO todos(content,date)
VALUES('zadanie 4' ,'2022-12-02');

```
### Ustawienie Program.cs
```cs
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
//app.MapGet("/", () => "Hello World!");

app.Run();
```

Dodać w katalogu Page
```console
dotnet new viewimports
dotnet new page -n Index
```
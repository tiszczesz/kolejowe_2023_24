using cw5_ef_sqlite;

BookDbContext db = new BookDbContext();
var books = db.Books.ToList();
Console.WriteLine(books.Count);
string path = AppContext.BaseDirectory;
Console.WriteLine(path);
string dbpath = System.IO.Path.Join(path,"dataDb.db");
Console.WriteLine(dbpath);

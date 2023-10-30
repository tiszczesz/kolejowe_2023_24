using cw5_ef_sqlite;

BookDbContext db = new BookDbContext();
var books = db.Books.ToList();
Console.WriteLine(books.Count);

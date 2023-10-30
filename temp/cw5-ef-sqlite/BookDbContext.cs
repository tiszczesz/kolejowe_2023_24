using Microsoft.EntityFrameworkCore;

namespace cw5_ef_sqlite;

public class BookDbContext:DbContext
{
    private string connString = "Data Source=books.db";
    public BookDbContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(connString);
    }
    public DbSet<Book> Books { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book>().HasData(
            new Book{
                Id = 1,
                Title = "ABC programowania w c#",
                Author = "Antoni Bałecki",
                Price = 23.78m
            },
             new Book{
                Id = 2,
                Title = "JavaScript versus TypeScript",
                Author = "Bożena Gryk",
                Price = 99.78m
            },
             new Book{
                Id = 3,
                Title = "Robotyka",
                Author = "Antoni Bałecki",
                Price = 67.78m
            }
        );
    }
}

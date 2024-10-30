using Microsoft.EntityFrameworkCore;

public class LibraryDBContext:DbContext
{
    public DbSet<Book> Books{get; set;}

    public LibraryDBContext(DbContextOptions options):base(options)
    {
        
    }
}
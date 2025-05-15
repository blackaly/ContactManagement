namespace DbContext;

using Microsoft.EntityFrameworkCore;
using Models;

public class AppDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=ContactsDB;Trusted_Connection=True;");
    }
}
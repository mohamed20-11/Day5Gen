

using Microsoft.EntityFrameworkCore;

public class InMeeeemoryStorage : DbContext, IStorage
{
    public DbSet<Customer> Trainees { get; set; }
    public DbSet<Product> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("db");
        base.OnConfiguring(optionsBuilder);
    }

}
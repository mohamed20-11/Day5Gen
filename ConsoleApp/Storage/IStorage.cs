

using Microsoft.EntityFrameworkCore;

public interface IStorage
{
    public DbSet<Customer>  Trainees { get; set; }
    public DbSet<Product> Courses { get; set; }
    int SaveChanges();
}
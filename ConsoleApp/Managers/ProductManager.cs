

using Microsoft.EntityFrameworkCore;

public class ProductManager : Manager<Product>, IProductManager
{
    public ProductManager(DbSet<Product> set): base(set)
    { }
}
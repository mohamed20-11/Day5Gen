

public interface IUnitOfWork
{
    ICustomerManager TMngr { get; }
    IProductManager CMngr { get; }
    int SaveChanges();
}
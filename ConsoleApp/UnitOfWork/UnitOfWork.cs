
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;

public class UnitOfWork : IUnitOfWork
{
    IStorage storage;
    public UnitOfWork(IStorage storage)
    {
        this.storage = storage;
    }
    private ICustomerManager tMngr;
    private IProductManager cMngr; 
    public ICustomerManager TMngr
    {
        get
        {
            if(tMngr == null)
                tMngr = new CustomerManager(storage.Trainees);
            return tMngr;
        }
    }
    public IProductManager CMngr
    {
        get
        {
            if (cMngr == null)
                cMngr = new ProductManager(storage.Courses);
            return cMngr;
        }
    }
    public int SaveChanges()
    {
        return storage.SaveChanges();
    }
}
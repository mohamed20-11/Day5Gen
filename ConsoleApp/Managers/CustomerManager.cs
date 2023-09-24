

using Microsoft.EntityFrameworkCore;

public class CustomerManager : Manager<Customer>, ICustomerManager
{
    public CustomerManager(DbSet<Customer> set) : base(set)
    {
    }
    public void GetExam()
    {
        throw new System.NotImplementedException();
    }
}

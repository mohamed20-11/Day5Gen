

using System;

public class Program
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;


        IContext storege = new DBContext();
        IStorage storgae = new InMeeeemoryStorage();
        IUnitOfWork unitOfWork = new UnitOfWork(storgae);
        ICustomerManager CSMngr = unitOfWork.TMngr;
        IProductManager PRMngr = unitOfWork.CMngr;



        CSMngr.Add(new Customer { Id = 1, Name = "Customer1" });
        CSMngr.Add(new Customer { Id = 2, Name = "Customer2" });
	CSMngr.Add(new Customer { Id = 3, Name = "Customer3" });
        unitOfWork.SaveChanges();
	 PRMngr.Add(new Product { Id = 3, Name = "Mart Products" });
	 PRMngr.Add(new Product { Id = 4, Name = Restaurants Products" });	
	 PRMngr.Add(new Product { Id = 5, Name = ClothesProducts" });



       


        unitOfWork.SaveChanges();





        foreach(Product c in PRMngr.GetAll())
            Console.WriteLine(c.Name);


        foreach (Customer t in CSMngr.GetAll())
            Console.WriteLine(t.Name);
        //Console.ReadKey();
        




    }
}
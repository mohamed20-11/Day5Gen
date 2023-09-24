

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class Manager<T> : IManager<T> where T : BaseModel
{
    private DbSet<T> set;
    public Manager(DbSet<T> set)
    {
        this.set = set;
    }
    public void Add(T item)
    {
        this.set.Add(item);
    }
    public IEnumerable<T> GetAll()
    {
        return set;
    }
    public T GetById(int id)
    {
        foreach(T item in set) 
            if(item.Id == id) return item;
        return null;
    }
    public void Remove(T item)
    {
        this.set.Remove(item);
    }
    public void Update(T item)
    {
        this.set.Update(item);
    }
}
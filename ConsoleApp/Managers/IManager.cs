

using System.Collections.Generic;

public interface IManager<T> where T : BaseModel
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T item);
    void Update(T item);
    void Remove(T item);
   
}
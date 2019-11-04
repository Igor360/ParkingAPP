using System;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public interface IRepository<T> : IDisposable where T : Model

    {
    IQueryable<T> All();
    T Get(int id);
    void Update(T model);
    void Create(T model);
    void Delete(int id);
    void Save();
    }
}
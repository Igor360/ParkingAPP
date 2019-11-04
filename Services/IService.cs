using System.Collections.Generic;
using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IService<T> where T : Model
    {
        IEnumerator<T> all();

        bool create(T entity);

        T read(int id);

        bool update(T entity);

        bool delete(int id);
    }
}
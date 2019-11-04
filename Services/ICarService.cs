using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICarService<T> : IService<T> where T : Model
    {
    }
}
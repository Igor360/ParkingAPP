using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICarsService<T> : IService<T> where T : Model
    {
    }
}
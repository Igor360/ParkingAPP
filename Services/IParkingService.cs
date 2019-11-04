using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IParkingService<T> : IService<T> where T : Model
    {
    }
}
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IParkingTicketsService<T> : IService<T> where T : Model
    {
    }
}
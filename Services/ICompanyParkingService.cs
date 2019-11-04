using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICompanyParkingService<T> : IService<T> where T : Model
    {
    }
}
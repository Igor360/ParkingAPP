using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IClientService<T> : IService<T> where T : Model
    {
    }
}
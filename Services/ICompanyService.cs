using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICompanyService<T> : IService<T> where T : Model
    {
    }
}
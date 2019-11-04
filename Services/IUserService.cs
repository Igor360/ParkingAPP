using System;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Services
{
    public interface IUserService : IService<User> 
    {
        User Authenticate(String username, String password);
        
        User Registration(User user, string password);
    }
}
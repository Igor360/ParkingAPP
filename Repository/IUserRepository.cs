using System;
using WebApplication1.Models;
using WebApplication1.Repository.Base;

namespace WebApplication1.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User findByEmailAndPassword(String email, byte [] PasswordHash, byte [] PasswordSalt);

        User findByName(String name);
    }
}
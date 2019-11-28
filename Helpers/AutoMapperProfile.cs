using AutoMapper;
using WebApplication1.Models;
using WebApplication1.Requests;

namespace WebApplication1.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AuthenticateRequest, User>();
            CreateMap<RegisterRequest, User>();
        }
    }
}
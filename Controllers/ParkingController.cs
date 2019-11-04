using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Responses;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        [HttpGet]
        public Response<Parking> getAll()
        {
            return new Response<Parking>("success", "good");
        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly IParkingService _service;

        public ParkingController(IParkingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Parking> GetAll()
        {
            return _service.all();
        }
    }
}
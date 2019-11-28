using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingPositionController : Controller
    {
        private readonly IParkingPositionService _service;

        public ParkingPositionController(IParkingPositionService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }
        
        [HttpPost]
        public void Save([FromBody] ParkingPosition parkingPosition)
        {
            _service.create(parkingPosition);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] ParkingPosition parkingPosition)
        {
            if (parkingPosition.id != 0 && parkingPosition.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            parkingPosition.id = id;
            _service.update(parkingPosition);
            return Ok(parkingPosition);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingTicketController : ControllerBase
    {
        private readonly IParkingTicketsService _service;

        public ParkingTicketController(IParkingTicketsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }
        
        [HttpPost]
        public void Save([FromBody] ParkingTicket parkingTicket)
        {
            _service.create(parkingTicket);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] ParkingTicket parkingTicket)
        {
            if (parkingTicket.id != 0 && parkingTicket.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            parkingTicket.id = id;
            _service.update(parkingTicket);
            return Ok(parkingTicket);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
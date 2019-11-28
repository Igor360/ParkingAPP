using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingPricingController : Controller
    {
        private readonly IParkingPricingService _service;

        public ParkingPricingController(IParkingPricingService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }
        
        [HttpPost]
        public void Save([FromBody] ParkingPricing parkingPricing)
        {
            _service.create(parkingPricing);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] ParkingPricing parkingPricing)
        {
            if (parkingPricing.id != 0 && parkingPricing.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            parkingPricing.id = id;
            _service.update(parkingPricing);
            return Ok(parkingPricing);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
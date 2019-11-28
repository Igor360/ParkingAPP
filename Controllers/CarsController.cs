using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Renci.SshNet.Messages.Authentication;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsService _service;

        public CarsController(ICarsService service)
        {
            _service = service;
        }
        
        [HttpGet] 
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }
       
        [HttpPost]
        public void Save([FromBody] Cars car)
        {
            _service.create(car);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] Cars car)
        {
            if (car.id != 0 && car.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            car.id = id;
            _service.update(car);
            return Ok(car);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
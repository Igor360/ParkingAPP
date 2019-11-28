using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyParkingController : Controller
    {
        private readonly ICompanyParkingService _service;

        public CompanyParkingController(ICompanyParkingService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }
        
        [HttpPost]
        public void Save([FromBody] CompanyParking companyParking)
        {
            _service.create(companyParking);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] CompanyParking companyParking)
        {
            if (companyParking.id != 0 && companyParking.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            companyParking.id = id;
            _service.update(companyParking);
            return Ok(companyParking);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
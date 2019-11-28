using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;

        public CompanyController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable> All()
        {
            return Ok(_service.all());
        }

        [HttpPost]
        public void Save([FromBody] Company company)
        {
            _service.create(company);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] Company company)
        {
            if (company.id != 0 && company.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            company.id = id;
            _service.update(company);
            return Ok(company);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
    }
}
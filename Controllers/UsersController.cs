using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Exceptions;
using WebApplication1.Models;
using WebApplication1.Requests;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _service;

        private readonly IMapper _mapper;
        
        public UsersController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<User>> All()
        {
            return Ok(_service.all());
        }
        
        [HttpPost]
        public void Save([FromBody] User user)
        {
            _service.create(user);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable> Put(int id, [FromBody] User user)
        {
            if (user.id != 0 && user.id != id)
            {
                return new BadRequestObjectResult(new
                {
                    Message="Incorrect object ID",
                }) ;
            }

            user.id = id;
            _service.update(user);
            return Ok(user);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.delete(id);
        }
        
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest userParam)
        {
            var user = _service.Authenticate(userParam.Name, userParam.Password);

            if (user == null)
            {
                return BadRequest(new {message = "Username or password is incorrect"});
            }

            return Ok(user);
        }
        
        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest model)
        {
            // map model to entity
            var user = _mapper.Map<User>(model);
            try
            {
                // create user
                _service.Registration(user, model.Password);
                return Ok();
            }
            catch (RegistrationException ex)
            {
                // return error message if there was an exception
                return BadRequest(new {message = ex.Message});
            }
        }
    }
}
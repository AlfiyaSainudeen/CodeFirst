using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Repository;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        //endpoints
        [HttpPost,Route("Register")]
        public IActionResult Create([FromBody] User user)
        {
            try
            {
                _userRepository.Register(user);
                return Ok(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("EditUser")]
        public IActionResult Edit([FromBody] User user)
        {
            try
            {
                _userRepository.EditUser(user);
                return Ok(user);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("Validate")]
        public IActionResult Validate([FromBody] Login login)
        {
            try
            {
                User user = _userRepository.Validate(login.UserName, login.Password);
                if(user !=null)
                {
                    return Ok(user);
                }
                else
                {
                    return BadRequest("Invalid Credentials");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

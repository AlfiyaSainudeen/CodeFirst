using HandsOnAPIUsingModelValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        List<Login> logins = new List<Login>()
        {
            new Login(){Username="Anna",Password="12345"},
            new Login(){Username="Merry",Password="12345"},
            new Login(){Username="Manoj",Password="12345"},
            new Login(){Username="chandra",Password="12345"},
        };
        List<User> users = new List<User>()
        { new User(){Name="Manoj",Id=1234,Email="manoj@gmail.com",Mobile="1234567890",Username="Manoj",Password="12345"}};
        [HttpPost]
        public IActionResult Validate(Login login)
        {

            // var user = logins.SingleOrDefault(u => u.Username == login.Username && u.Password == login.Password);
            try
            {
                if (ModelState.IsValid)
                {
                    //var user = (from u in logins
                    // where u.Username == login.Username && u.Password == login.Password
                    //
                    //select u).SingleOrDefault();
                    var user = (from l in logins
                                join u in users
                                on l.Username equals u.Username
                                where u.Username == login.Username && u.Password == login.Password
                                select u).SingleOrDefault();
                    if (user != null)
                    {
                        return StatusCode(200, user);
                    }
                    else
                    {
                        return StatusCode(200, new JsonResult("InValid User credentails"));
                    }

                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
             
            }
        }
        [HttpPost,Route("Register")]
        public IActionResult Register([FromBody] User user)//[formbody] expected model data from the request body
        {
            try
            {
                if (ModelState.IsValid)
                {
                    user.Id = new Random().Next(1000, 9999);
                    //add model data to backend table
                    users.Add(user);
                    return Ok(users);
                    
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}

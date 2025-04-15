using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dtos;
using WebApplication2.Services;
using WebApplication2.Services.Interface;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController(IUserService userService) : Controller
    {
        [HttpPost("Add")]
        public IActionResult AddUser([FromBody] InsertUserDto userDto)
        {
            try
            {
                userService.AddUser(userDto);
                return Ok("User added successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [HttpGet("GetByAll")]
        public IActionResult GetByAll()
        {
            try
            {
                var result = userService.GetAllUsers();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var result = userService.GetUserById(id);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UpdateUserDto userDto)
        {
            try
            {
                userService.UpdateUser(id, userDto);
                return Ok("User updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

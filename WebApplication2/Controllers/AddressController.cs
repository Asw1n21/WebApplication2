using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Dtos;
using WebApplication2.Services;
using WebApplication2.Services.Interface;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController(IAddressService AddressService) : ControllerBase
    {
        [HttpPost("Add")]
        public IActionResult AddAddress([FromBody] InsertAddressDto AddressDto)
        {
            try
            {
                AddressService.AddAddress(AddressDto);
                return Ok("Address added successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}

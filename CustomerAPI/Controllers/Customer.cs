using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customer : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            // Simulate a delay
            await Task.Delay(2000);

            // Mock customer data
            Customer customer = new Insurance. Customer ()
            {
                
            };
            return Ok(customer);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Insurance.Model;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            // Simulate a delay
            await Task.Delay(2000);


            // Mock customer data
            var customer = new Insurance.Model.Customer()
            {
                Id = id,
                Name = "John Doe",
                Email = "rakesh.chawathari@gmail.com",
                Phone = "+19030234234",
                Address = "123 Main St",
                City = "Buford",
                State = "GA",
                Country = "USA",
                PostalCode = "30519"
            };
            return Ok(customer);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Insurance.Model;
namespace PolicyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetPolicy(int customerId)
        {
            // Simulate a delay
            await Task.Delay(3000);

            IEnumerable<Policy> policies = new List<Policy>()
            {
                new Policy() { Id=1, CustomerId=1 , PolicyName="Basic",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id=2,CustomerId=2, PolicyName="WWP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id = 3,  CustomerId=3 , PolicyName="WCP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id = 4,  CustomerId=4 , PolicyName="Basic",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id=5, CustomerId=5 , PolicyName="WWP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id = 6,  CustomerId=6 , PolicyName="WCP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id=7, CustomerId=7 , PolicyName="WWP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id = 8,  CustomerId=8 , PolicyName="Basic",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id=9, CustomerId=9 , PolicyName="WCP",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
                new Policy() { Id=10,CustomerId=10 , PolicyName="Basic",PolicyType="New", StartDate= DateTime.Now, ExpiryDate= DateTime.Now.AddMonths(12),Status= Insurance.Common.Enum.PolicyStatusEnum.Initial},
            };


            // Mock policy data
            var policy = policies.FirstOrDefault(x => x.CustomerId == customerId);
            return Ok(policy);
        }
    }
}

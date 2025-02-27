using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Insurance.Model;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

namespace InsuranceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InsuranceController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configurationManager;   
        public InsuranceController(IHttpClientFactory httpClientFactory, IConfiguration configurationManager )
        {
            _httpClientFactory = httpClientFactory;
            _configurationManager = configurationManager;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetInsuranceData(int Id)
        {
            var customerTask = GetCustomerAsync(Id);
            var policyTask = GetPolicyAsync(Id);

            await Task.WhenAll(customerTask, policyTask);

            var customer = await customerTask;
            var policy = await policyTask;

			return Ok(new Insurance.Model.InsuranceResponse{ Customer = customer, Policy = policy });
        }

        private async Task<Customer> GetCustomerAsync(int customerId=0)
        {
            var client = _httpClientFactory.CreateClient();
            var customerApiUrl = string.Format(_configurationManager.GetSection("ThirdPartyAPI:CustomerApiUrl").Value, customerId);
            var response = await client.GetStringAsync(customerApiUrl);
            return JsonSerializer.Deserialize<Customer>(response);
        }

        private async Task<Policy> GetPolicyAsync(int customerId=0)
        {
            var client = _httpClientFactory.CreateClient();
            var policyApiUrl = string.Format(_configurationManager.GetSection("ThirdPartyAPI:PolicyApiUrl").Value, customerId);

            var response = await client.GetStringAsync(policyApiUrl);
            return JsonSerializer.Deserialize<Policy>(response);
        }
    }
}

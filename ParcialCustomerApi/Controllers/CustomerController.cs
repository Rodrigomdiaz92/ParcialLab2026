using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcialCustomer.Domain.Interfaces;





namespace ParcialCustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {

            _customerRepository = customerRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            //var sqlServer = new SQLServer();
            return Ok(_customerRepository.GetName());
        }

        [HttpPost]
        public IActionResult GetCustomer()
        {
            return Ok(_customerRepository.GetName());
        }
        [HttpPut]
        public IActionResult UpdateCustomer()
        {
            return Ok(_customerRepository.GetName());
            //return Ok(_CustomerRepository.UpdateCustomer());
        }
        [HttpDelete]
        public IActionResult DeleteCustomer()
        {
            return Ok(_customerRepository.GetName());
            //return Ok(_CustomerRepository.DeleteCustomer());
        }
    }
}

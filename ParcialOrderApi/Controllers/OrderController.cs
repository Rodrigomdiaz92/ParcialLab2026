using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcialOrder.Domain.Interfaces;




namespace ParcialOrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {

            _orderRepository = orderRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_orderRepository.GetName());
        }

        [HttpPost]
        public IActionResult GetProduct()
        {
            return Ok(_orderRepository.GetName());
        }
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok(_orderRepository.GetName());
            
        }
        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return Ok(_orderRepository.GetName());
            
        }
    }
}

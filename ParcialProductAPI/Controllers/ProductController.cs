using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcialProduct.Domain.Interfaces;



namespace ParcialProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController( IProductRepository productRepository) {
           
            _productRepository = productRepository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            //var sqlServer = new SQLServer();
            return Ok(_productRepository.GetName());
        }

        [HttpPost]
        public IActionResult GetProduct()
        {
            return Ok(_productRepository.GetName());
        }
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok(_productRepository.GetName());
            //return Ok(_productRepository.UpdateProduct());
        }
        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return Ok(_productRepository.GetName());
            //return Ok(_productRepository.DeleteProduct());
        }
    }
}

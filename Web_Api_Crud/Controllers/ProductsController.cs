using Microsoft.AspNetCore.Mvc;
using Web_Api_Crud.Data;
using Web_Api_Crud.Interface;
using Web_Api_Crud.Models;

namespace Web_Api_Crud.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("product")]
        public IActionResult GetListProduct()
        {
            try
            {
                var result = _productService.GetListProduct();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public IActionResult GetProductById(int Id)
        {
            try
            {
                var result = _productService.GetProductById(Id);
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500,ex.Message); }
        }

        [HttpPost("add a product")]
        public IActionResult CreatNewProduct(Product newproduct)
        {
            try
            {
                var result = _productService.CreatNewProduct(newproduct);
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateProduct(int Id, Product inforProduct)
        {
            try
            {
                var result = _productService.UpdateProduct(Id, inforProduct);
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpDelete("{Id}")]
        public bool DeleteProduct(int Id)
        {
            //try
            //{
                var result = _productService.DeleteProduct(Id);
                return true;
            //}
            //catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
    }
}

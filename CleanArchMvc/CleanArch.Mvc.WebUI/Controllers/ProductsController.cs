using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        public readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;

        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var result = await _productService.GetProducts();
            return View(result);
        }
    }
}

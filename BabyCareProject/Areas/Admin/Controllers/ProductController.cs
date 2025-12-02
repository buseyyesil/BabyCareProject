using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IInstructorService _instructorService;

        public ProductController(IProductService productService, IInstructorService instructorService)
        {
            _productService = productService;
            _instructorService = instructorService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.GetAllAsync();
            return View(values);
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            // Şimdilik eğitmeni text girdiğin için ViewBag gerekmez
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateAsync(createProductDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var value = await _productService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateAsync(updateProductDto);
            return RedirectToAction("Index");
        }
    }
}

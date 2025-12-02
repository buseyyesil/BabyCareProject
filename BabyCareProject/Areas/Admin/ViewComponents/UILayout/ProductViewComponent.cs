using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents.UILayout
{
    [ViewComponent(Name = "ProductViewComponent")]
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllAsync();
            return View(values);
        }
    }
}
using BabyCareProject.Services.FooterServices.FooterGalleryServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterGalleryViewComponent")]
    public class FooterGalleryViewComponent : ViewComponent
    {
        private readonly IFooterGalleryService _footerGalleryService;

        public FooterGalleryViewComponent(IFooterGalleryService footerGalleryService)
        {
            _footerGalleryService = footerGalleryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _footerGalleryService.GetActiveFooterGalleriesAsync();
            return View(values);
        }
    }
}
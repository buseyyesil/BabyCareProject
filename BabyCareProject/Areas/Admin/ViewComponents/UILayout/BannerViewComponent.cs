using BabyCareProject.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "BannerViewComponent")]
    public class BannerViewComponent : ViewComponent
    {
        private readonly IBannerService _bannerService;

        public BannerViewComponent(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetActiveBannersAsync();
            return View(values);
        }
    }
}
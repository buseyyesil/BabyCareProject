using BabyCareProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{

    [ViewComponent(Name = "AboutViewComponent")]
    public class AboutViewComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public AboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutService.GetAboutAsync();
            return View(value);
        }
    }
}
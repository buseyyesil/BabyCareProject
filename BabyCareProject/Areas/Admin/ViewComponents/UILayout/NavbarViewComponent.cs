using BabyCareProject.Services.FooterServices.FooterInformationServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.ViewComponents.UILayout
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly IFooterInformationService _footerInformationService;

        public NavbarViewComponent(IFooterInformationService footerInformationService)
        {
            _footerInformationService = footerInformationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _footerInformationService.GetFooterInformationAsync();
            return View(value);
        }
    }
}

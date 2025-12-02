using BabyCareProject.Services.FooterServices.FooterInformationServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterInformationViewComponent")]
    public class FooterInformationViewComponent : ViewComponent
    {
        private readonly IFooterInformationService _footerInformationService;

        public FooterInformationViewComponent(IFooterInformationService footerInformationService)
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
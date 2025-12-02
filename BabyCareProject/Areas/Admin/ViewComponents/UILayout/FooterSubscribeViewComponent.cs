using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterSubscribeViewComponent")]
    public class FooterSubscribeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
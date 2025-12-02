using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "TestimonialViewComponent")]
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialViewComponent(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetActiveTestimonialsAsync();
            return View(values);
        }
    }
}
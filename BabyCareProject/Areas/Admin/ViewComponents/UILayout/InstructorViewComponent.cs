using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.ViewComponents.UILayout
{
    [ViewComponent(Name = "InstructorViewComponent")]
    public class InstructorViewComponent : ViewComponent
    {
        private readonly IInstructorService _instructorService;

        public InstructorViewComponent(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _instructorService.GetAllInstructorAsync();
            return View(values);
        }
    }
}
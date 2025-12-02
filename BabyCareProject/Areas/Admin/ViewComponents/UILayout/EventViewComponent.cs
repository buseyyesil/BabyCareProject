using BabyCareProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "EventViewComponent")]
    public class EventViewComponent : ViewComponent
    {
        private readonly IEventService _eventService;

        public EventViewComponent(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _eventService.GetActiveEventsAsync();
            return View(values);
        }
    }
}
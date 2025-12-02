using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllEventAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventDto createEventDto)
        {
            await _eventService.CreateEventAsync(createEventDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateEvent(string id)
        {
            var value = await _eventService.GetEventByIdAsync(id);
            var updateDto = new UpdateEventDto
            {
                EventId = value.EventId,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                EventDate = value.EventDate,
                EventTime = value.EventTime,
                Location = value.Location,
                AgeRange = value.AgeRange,
                Capacity = value.Capacity,
                Order = value.Order,
                IsActive = value.IsActive
            };
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEvent(UpdateEventDto updateEventDto)
        {
            await _eventService.UpdateEventAsync(updateEventDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteEvent(string id)
        {
            await _eventService.DeleteEventAsync(id);
            return RedirectToAction("Index");
        }
    }
}
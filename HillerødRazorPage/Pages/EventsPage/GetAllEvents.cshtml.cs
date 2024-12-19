using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Pages.EventsPage
{
    public class GetAllEventsModel : PageModel
    {
       
        private EventService _eventService;

        public GetAllEventsModel(EventService eventService)
        {
            _eventService = eventService;
        }

        public Dictionary<int, CustomEvent> Events { get; private set; }

        public void OnGet()
        {
            Events = _eventService.GetAllCustomEvents();
        }
    }
}

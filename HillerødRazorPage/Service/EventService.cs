using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Service
{
    public class EventService
    {
        private Dictionary<int, CustomEvent> _event;

        private CustomEventsRepo _eventRepo = new CustomEventsRepo();

        public EventService()
        {
            _event = _eventRepo.GetAllCustomEvents();
        }
        public Dictionary<int, CustomEvent> GetAllCustomEvents()
        {
            return _event;
        }
        //public static List<CustomEvent> GetCustomEvents()
        //{
        //    return CustomEvent.Values.Tolist();
        //}
    }
   
}

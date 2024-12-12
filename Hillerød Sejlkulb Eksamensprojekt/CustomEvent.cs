using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class CustomEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string DescriptionOfEvent { get; set; }



        public CustomEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent)
        {
            EventId = eventId;
            EventName = eventName;
            DateOfEvent = dateOfEvent;
            DescriptionOfEvent = descriptionOfEvent;
        }

        public override string ToString()
        {
            //return $"Event Id: " + EventId + " Event name: " + EventName + " Date of event: " + DateOfEvent + " Description: " + DescriptionOfEvent;
            return $"Event name: {EventName} \nEvent Id: {EventId} \nDate: {DateOfEvent} \nDescription: {DescriptionOfEvent}";
        }
    }
}

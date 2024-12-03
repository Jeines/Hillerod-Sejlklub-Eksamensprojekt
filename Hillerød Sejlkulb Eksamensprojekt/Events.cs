using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Events
    {
        public string EventId { get; set; }
        public int EventName { get; set; }
        public string DateOfEvent { get; set; }
        public double TimeOfEvent { get; set; }
        public string DescriptionOfEvent { get; set; }
        


        public Events(string eventId, int eventName, string dateOfEvent, double timeOfEvent, string descriptionOfEvent)
        {
            EventId = eventId;
            EventName = eventName;
            DateOfEvent = dateOfEvent;
            TimeOfEvent = timeOfEvent;
            DescriptionOfEvent = descriptionOfEvent;
        }

        public override string ToString()
        {
            return $"Event Id: " + EventId + " Event name: " + EventName + " Date of event: " + DateOfEvent + " Time of event: " + TimeOfEvent + " Description: " + DescriptionOfEvent;
        }
    }
}

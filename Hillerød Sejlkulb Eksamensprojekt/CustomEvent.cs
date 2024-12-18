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
        public List<Member> Participants { get; set; } = new List<Member>();
        public List<Boat> EventBoats { get; set; } = new List<Boat>();



        public CustomEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent, List<Boat> eventBoats, List<Member> participants)
        {
            EventId = eventId;
            EventName = eventName;
            DateOfEvent = dateOfEvent;
            DescriptionOfEvent = descriptionOfEvent;
            Participants = participants;
            EventBoats = eventBoats;
        }

        public void AddParticipant(Member member)
        {
            if (!Participants.Contains(member))
                Participants.Add(member);
        }

        public void AddEventBoat(Boat boat)
        {
            if (!EventBoats.Contains(boat))
                EventBoats.Add(boat);
        }








        public override string ToString()
        {
            string eventDetails = $"Event name: {EventName} \nEvent Id: {EventId} \nDate: {DateOfEvent} \nDescription: {DescriptionOfEvent} \n\nEventboat: \n\n";

            if (EventBoats.Count > 0)
            {
                foreach (var Eventboat in EventBoats)
                {
                    eventDetails += Eventboat.ToString() + "\n\nParticipants to the event: \n\n";
                }
            }
            if (EventBoats.Count == 0)
            {
                eventDetails += "No eventboat yet\n\n" + "Participants:\n\n";
            }
            if (Participants.Count > 0)
            {

                foreach (var participant in Participants)
                {
                    eventDetails += participant.ToString() + "\n";

                }
            }
            if (Participants.Count == 0)
            {
                eventDetails += "No participants yet\n" + "\n";
            }
            return eventDetails;
        }
    }
}

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

        

        public CustomEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent, List<Member> participants)
        {
            EventId = eventId;
            EventName = eventName;
            DateOfEvent = dateOfEvent;
            DescriptionOfEvent = descriptionOfEvent;
            Participants = participants;

        }
        
        public void AddParticipant(Member member)
        {
            if (!Participants.Contains(member))
                Participants.Add(member);
        }










        public override string ToString()
        {
            return $"Event name: {EventName} \nEvent Id: {EventId} \nDate: {DateOfEvent} \nDescription: {DescriptionOfEvent}\nParticipants:\n\n{string.Join("\n",Participants.Select(m => m.ToString()))}";
        }
    }
}

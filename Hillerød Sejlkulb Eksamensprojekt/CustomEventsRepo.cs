using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class CustomEventsRepo
    {
        private Dictionary<int, CustomEvent> _events;
        private int _nextId;
        public CustomEventsRepo()
        {
            _nextId = 1;
            _events = new Dictionary<int, CustomEvent>();
            Console.WriteLine("Tilføjer events og printer listen");
            AddEvent(_nextId, "Klargøring af både", new DateTime(2024, 4, 1, 10, 0, 0), "Klargøring af både",  new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Første tirsdagssejlads", new DateTime(2024, 4, 30, 12, 0, 0), "Kapsejlads med joller og kølbåde. Skippermøde i klubhuset", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Warships", new DateTime(2024, 7, 4, 18, 0, 0), "Vi drager ud på søen og udfører vores bedste destruction derby på vand", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Sø-regatta", new DateTime(2024, 9, 1, 14, 0, 0), "alle både på vandet", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Sjælland rundt på indersiden", new DateTime(2024, 6, 15, 10, 0, 0), "Det bliver bare sjovt!", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Sjælland rundt på indersiden", new DateTime(2024, 6, 16, 10, 0, 0), "Det bliver bare sjovt!", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Bro i og standerhejsning", new DateTime(2024, 4, 27, 9, 0, 0), "Tovholder Henrik Kromann. Vognmanden kommer kl 10:00. Standeren bliver hejst kl. 15:00", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Første torsdagssejlads", new DateTime(2024, 5, 2, 16, 30, 0), "Træningssejlads for seniorer og juniorer. Juniorer mødes på havnen kl. 16:30. Seniorer mødes på havnen kl. 17:00.", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Crash-kursus i jollesejlads", new DateTime(2024, 5, 4, 12, 0, 0), "Første weekend i Maj måned holder klubben et intensivt jollekursus. Det er planen at sejle i Laserjoller, med et formiddagshold og et eftermiddagshold, hvis interessen er stor nok. Max deltagerantal per hold er 5. Tilmelding er bindende. Der aftales opfølgning på de efterfølgende 2 tirsdage. Afslutning på kursus lørdag den 25. og søndag den 26. Maj med jolleprøve. Ud over praktisk sejlads vil der blive underist i sejlteori, søvejsregler og sikkerhed.", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Crash-kursus i jollesejlads", new DateTime(2024, 5, 5, 12, 0, 0), "Første weekend i Maj måned holder klubben et intensivt jollekursus. Det er planen at sejle i Laserjoller, med et formiddagshold og et eftermiddagshold, hvis interessen er stor nok. Max deltagerantal per hold er 5. Tilmelding er bindende. Der aftales opfølgning på de efterfølgende 2 tirsdage. Afslutning på kursus lørdag den 25. og søndag den 26. Maj med jolleprøve. Ud over praktisk sejlads vil der blive underist i sejlteori, søvejsregler og sikkerhed.", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Den årlige arbejdsdag.", new DateTime(2042, 6, 2, 12, 0, 0), "Alle klubber giver en hånd til vedligeholdelse af klubshus og anlæg.", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Sommertur", new DateTime(2024, 6, 9, 10, 0, 0), "Sejler op langs Esrum Søs kyst med grill og hygge. Tovholder Ib Andersen", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Lynæs 14 træf på Esrum Sø.", new DateTime(2024, 8, 10, 10, 0, 0), "Tovholder Michael Kreiberg / Ib Andersen", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Lynæs 14 træf på Esrum Sø.", new DateTime(2024, 8, 11, 10, 0, 0), "Tovholder Michael Kreiberg / Ib Andersen", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Klubmesterskab for seniorer.", new DateTime(2024, 9, 15, 11, 0, 0), "Første start klokken 11. Tovholder Ib Andersen", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Klubmesterskab for juniorer.", new DateTime(2024, 9, 26, 17, 0, 0), "Første start kl 17. Tovholder??", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Afrigning, bro op og standerstrygning.", new DateTime(2024, 10, 5, 9, 0, 0), "Tovholder Henrik Kromann", new List<Boat>(), new List<Member>());
            AddEvent(_nextId, "Generalforsamling", new DateTime(2024, 11, 26, 12, 0, 0), "", new List<Boat>(), new List<Member>());
        }
        public void AddEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent, List<Boat>eventBoat, List<Member> participant)
        {
            var customEvent = new CustomEvent(eventId, eventName, dateOfEvent, descriptionOfEvent, eventBoat, participant) { };
            _events.TryAdd(_nextId++, customEvent);
        }

        // Gør det muligt at se events ud fra bestemt id. 
        public CustomEvent GetEvent(int eventId)
        {
            if (_events.ContainsKey(eventId))
                return _events[eventId];
            return null;
        }

        // Gør det muligt at opdatere events ud fra id. Den returnerer derimod false hvis den ikke kan finde id. 
        public bool UpdateCustomEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent, List<Boat>eventBoat, List<Member>participant)
        {
            if (_events.ContainsKey(eventId))
            {
                _events[eventId].EventName = eventName;
                _events[eventId].DateOfEvent = dateOfEvent;
                _events[eventId].DescriptionOfEvent = descriptionOfEvent;
                _events[eventId].Participants = participant;
                _events[eventId].EventBoats = eventBoat;
                return true;
            } 
            return false;
        }

        // Sletter et bestemt event ved hjælp af id. 
        public bool DeleteEvent(int eventId)
        { 
            if (_events.ContainsKey(eventId))
            {
                _events.Remove(eventId);

            }
            return false;
        }

        // Tilføjer deltager til et bestemt event. Den søger efter event ud fra id og tilføjer en bestemt deltager med id. 
        public bool AddParticipantToCustomEvent(int eventId, Member id)
        {
            if (_events.ContainsKey(eventId))
            {
                _events[eventId].AddParticipant(id);
            }
            return false;
        }
        
        // Tilføjer båd til et bestemt event. Den søger efter event ud fra id og tilføjer en bestemt båd ud fra id. 
        public bool AddEventBoatToCustomEvent(int eventId, Boat boatId)
        {
            if (_events.ContainsKey(eventId))
            {
                _events[eventId].AddEventBoat(boatId);
            }
            return false;
        }
        //  Printer alle events
        public Dictionary<int, CustomEvent> GetAllCustomEvents()
        {
            return _events;
        }
    }


}
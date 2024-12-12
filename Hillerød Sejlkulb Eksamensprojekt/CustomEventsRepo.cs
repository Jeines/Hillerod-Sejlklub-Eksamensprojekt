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
        }
        public void AddEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent)
        {
            var customEvent = new CustomEvent(eventId, eventName, dateOfEvent, descriptionOfEvent) { };
            _events.TryAdd(_nextId++, customEvent);
        }
        // Gør det muligt at se events. 
        public CustomEvent GetEvent(int eventId)
        {
            if (_events.ContainsKey(eventId))
                return _events[eventId];
            return null;
        }

        // Gør det muligt at opdatere events
        public bool UpdateCustomEvent(int eventId, string eventName, DateTime dateOfEvent, string descriptionOfEvent)
        {
            if (_events.ContainsKey(eventId))
            {
                _events[eventId].EventName = eventName;
                _events[eventId].DateOfEvent = dateOfEvent;
                _events[eventId].DescriptionOfEvent = descriptionOfEvent;
                return true;
            }
            return false;
        }

        // Gør det muligt at slette event
        public bool DeleteEvent(int eventId)
        {
            return _events.Remove(eventId);
        }
        public void PrintEventList()
        {
            foreach (CustomEvent e in _events.Values)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
            }

        }
        public void TestEventsList()
        {
            Console.WriteLine("Tilføjer events og printer listen");
            AddEvent(_nextId, "Klargøring af både", new DateTime(2024, 4, 1), "Klargøring af både");
            AddEvent(_nextId, "Første tirsdagssejlads", new DateTime(2024, 4, 30), "Kapsejlads med joller og kølbåde. Skippermøde i klubhuset");
            AddEvent(_nextId, "Warships", new DateTime(2024, 7, 4, 18, 0, 0), "Vi drager ud på søen og udfører vores bedste destruction derby på vand");
            AddEvent(_nextId, "Sø-regatta", new DateTime(2024, 9, 1, 14, 0, 0), "alle både på vandet");
            //AddEvent(_nextId, "Sjælland rundt på indersiden", new DateTime ()"Lørdag-Søndag den 15.-16. Juni 2024", 0, "Det bliver bare sjovt!");
            AddEvent(_nextId, "Bro i og standerhejsning", new DateTime(2024, 4, 27, 9, 0, 0), "Tovholder Henrik Kromann. Vognmanden kommer kl 10:00. Standeren bliver hejst kl. 15:00");
            AddEvent(_nextId, "Første torsdagssejlads", new DateTime(2024, 5, 2, 16, 30, 0), "Træningssejlads for seniorer og juniorer. Juniorer mødes på havnen kl. 16:30. Seniorer mødes på havnen kl. 17:00.");
            //AddEvent(_nextId, "Crash-kursus i jollesejlads", new DateTime() "Lørdag den 4. Maj og Søndag den 5. Maj 2024", 12, "Første weekend i Maj måned holder klubben et intensivt jollekursus. Det er planen at sejle i Laserjoller, med et formiddagshold og et eftermiddagshold, hvis interessen er stor nok. Max deltagerantal per hold er 5. Tilmelding er bindende. Der aftales opfølgning på de efterfølgende 2 tirsdage. Afslutning på kursus lørdag den 25. og søndag den 26. Maj med jolleprøve. Ud over praktisk sejlads vil der blive underist i sejlteori, søvejsregler og sikkerhed.");
            AddEvent(_nextId, "Den årlige arbejdsdag.", new DateTime(2042, 6, 2, 12, 0, 0), "Alle klubber giver en hånd til vedligeholdelse af klubshus og anlæg.");
            AddEvent(_nextId, "Sommertur", new DateTime(2024, 6, 9, 10, 0, 0), "Sejler op langs Esrum Søs kyst med grill og hygge. Tovholder Ib Andersen");
            //AddEvent(_nextId, "Lynæs 14 træf på Esrum Sø.", new DateTime() "lørdag-søndag den 10.-11. August 2024", 0, "Tovholder Michael Kreiberg / Ib Andersen");
            AddEvent(_nextId, "Klubmesterskab for seniorer.", new DateTime(2024, 9, 15, 11, 0, 0), "Første start klokken 11. Tovholder Ib Andersen");
            AddEvent(_nextId, "Klubmesterskab for juniorer.", new DateTime(2024, 9, 26, 17, 0, 0), "Første start kl 17. Tovholder??");
            AddEvent(_nextId, "Afrigning, bro op og standerstrygning.", new DateTime(2024, 10, 5, 9, 0, 0), "Tovholder Henrik Kromann");
            AddEvent(_nextId, "Generalforsamling", new DateTime(2024, 11, 26, 12, 0, 0), "");
            PrintEventList();
            Console.WriteLine();
            Console.WriteLine("Finder event nummer 2");
            Console.WriteLine(GetEvent(2).ToString());
            Console.WriteLine();
            Console.WriteLine("Ændrer event 7 til den 9. Maj");
            UpdateCustomEvent(2, "Første torsdagssejlads", new DateTime(2024, 5, 9), "Træningssejlads for seniorer og juniorer. Juniorer mødes på havnen kl. 16:30. Seniorer mødes på havnen kl. 17:00.");
            Console.WriteLine(GetEvent(2).ToString());
            Console.WriteLine();
            Console.WriteLine("Fjerner event 7");
            Console.WriteLine();
            DeleteEvent(2);
            PrintEventList();
            Console.WriteLine();


        }

    }


}





//    Console.WriteLine("Eventslistetester:::::::::!");
//    Console.WriteLine();
////    Console.WriteLine("Printer events listen: ");
////    EventsList.PrintEventsList();
////    Console.WriteLine();
//}
using Hillerød_Sejlkulb_Eksamensprojekt;
using System.Security.Cryptography.X509Certificates;


void PrintBoats(List<Boat> boatList)
{
    foreach (Boat Boats in boatList)
    {
        Console.WriteLine(Boats);
    }

}

//BoatsList print program
BoatsRepo boats = new BoatsRepo();
PrintBoats(boats.GetAllBoats());


///////////////////////////////////////////////////////////////////////////


void PrintMembersList(List<Member> memberList)
{
    foreach (Member members in memberList)
    {
        Console.WriteLine(members);
    }
}


//MembersList print program
MembersRepo members = new MembersRepo();
PrintMembersList(members.GetAllMembers());


/////////////////////////////////////////////////////////////////////////////


void PrintSubscribtionList(List<Subscribtion> subList)
{
    foreach (Subscribtion subscribtion in subList)
    {
        Console.WriteLine(subscribtion);
    }
}

// Subscribtion og priser print program
SubscribtionRepo sub = new SubscribtionRepo();
PrintSubscribtionList(sub.GetAllSubscribtions());


//////////////////////////////////////////////////////////////////////////



//Åbnings Tid print program
ÅbningsTider Åbning = new ÅbningsTider();
Åbning.Start();



































































































































// Test af events
void PrintEventsList(Dictionary<int, CustomEvent> eventsList)
{
    foreach (var customEvent in eventsList)
    { 
        Console.WriteLine(customEvent); 
    }
}
CustomEventsRepo customEventsRepo = new CustomEventsRepo();
PrintEventsList(customEventsRepo.GetAllCustomEvents());
TestCRUDMethods();

// Metode der tester CRUD
//customEventsRepo.TestCRUDMethods();

void TestCRUDMethods()
{
    
    Console.WriteLine();
    Console.WriteLine("Tilføjer nyt event nummer 13");
    customEventsRepo.AddEvent(13, "TESTESTETSTTESTETS", new DateTime(2024, 11, 26, 12, 0, 0), "");
    Console.WriteLine();
    Console.WriteLine("Finder event nummer 2");
    Console.WriteLine(customEventsRepo.GetEvent(2).ToString());
    Console.WriteLine();
    Console.WriteLine("Ændrer event 7 til den 9. Maj");
    customEventsRepo.UpdateCustomEvent(2, "Første torsdagssejlads", new DateTime(2024, 5, 9), "Træningssejlads for seniorer og juniorer. Juniorer mødes på havnen kl. 16:30. Seniorer mødes på havnen kl. 17:00.");
    Console.WriteLine(customEventsRepo.GetEvent(2).ToString());
    Console.WriteLine();
    Console.WriteLine("Fjerner event 7");
    Console.WriteLine();
    customEventsRepo.DeleteEvent(2);
    PrintEventsList(customEventsRepo.GetAllCustomEvents());
    Console.WriteLine();

}
//Console.WriteLine(TestCRUDMethods());
































//namespace HillerødConsole

//{
//    public class Program
//    { 
//        BoatsList.PrintBoats
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        BoatsList.PrintBoats();
//    //    }

//    }
//}
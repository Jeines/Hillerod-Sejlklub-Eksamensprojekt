using Hillerød_Sejlkulb_Eksamensprojekt;

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
TestCRUDBoats();


void TestCRUDBoats()
{
    Console.WriteLine();
    Console.WriteLine("Finder båd nummer 4");
    Console.WriteLine(boats.GetBoatById(4));
    Console.WriteLine();
    Console.WriteLine("Ændrer båd til en ny båd");
    boats.UpdateBoats(2, new SpeedBoat( 2, "flimmerfod ", 3.9, 2.2, 105,"Flimsemoter 87" , " Crew 4 person. ", " Det her er en speedbåd suveræng og hurtig ", "Motor i stykker "));

    Console.WriteLine(boats.GetBoatById(2).ToString());
    Console.WriteLine();
    Console.WriteLine("Fjerner båd nummer 5");
    Console.WriteLine();
    boats.RemoveBoat(5);
    PrintBoats(boats.GetAllBoats());
    Console.WriteLine();

}


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
TestCRUDMembers();


void TestCRUDMembers()
{
    Console.WriteLine();
    Console.WriteLine("Finder medlem nummer 8");
    Console.WriteLine(members.GetMember(8));
    Console.WriteLine();
    Console.WriteLine("Ændrer member 11 detaljer");
    members.Update(11, new Member(11, "Pesu ", "Pluma",25, 50210312, "Pesu.Pluma@Music.com","El mexico 9"));
    Console.WriteLine(members.GetMember(11).ToString());
    Console.WriteLine();
    Console.WriteLine("Fjerner member nummer 14");
    Console.WriteLine();
    members.RemoveMember(14);
    PrintMembersList(members.GetAllMembers());
    Console.WriteLine();
}


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
TestCRUDSubscribtion();


void TestCRUDSubscribtion()
{
    Console.WriteLine();
    Console.WriteLine("Finder Subscribtion nummer 2");
    Console.WriteLine(sub.GetSubscribtion(2));
    Console.WriteLine();
    Console.WriteLine("Ændre Subscribtion 4");
    sub.Update(4, new Subscribtion(4, "et eller andet",250));
    Console.WriteLine(sub.GetSubscribtion(4).ToString());
    Console.WriteLine();
    Console.WriteLine("Fjerner Subscribtion nummer 1 ");
    Console.WriteLine();
    sub.RemoveSubscription(1);
    PrintSubscribtionList(sub.GetAllSubscribtions());
    Console.WriteLine();

}


//////////////////////////////////////////////////////////////////////////




void PrintVedtægter(List<string> vedtægterrepo)
{
    foreach (string vedtægter in vedtægterrepo)
    {
        Console.WriteLine(vedtægter);
    }
}
Vedtægter ved = new Vedtægter();
PrintVedtægter(ved.GetVedtægter());
Console.WriteLine();
Console.WriteLine(ved.GetVedtægt(2));
Console.WriteLine();


//////////////////////////////////////////////////////////////////////////////


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
void TestCRUDMethods()
{
    Console.WriteLine("\n" + "Tilføjer nyt event nummer 13"+"\n");
    customEventsRepo.AddEvent(13, "TESTESTETSTTESTETS", new DateTime(2024, 11, 26, 12, 0, 0),"", new List<Member>());
    Console.WriteLine("Finder event nummer 2");
    Console.WriteLine(customEventsRepo.GetEvent(2).ToString());
    Console.WriteLine();
    Console.WriteLine("Ændrer event 7 til den 9. Maj");
    customEventsRepo.UpdateCustomEvent(2, "Første torsdagssejlads", new DateTime(2024, 5, 9), "Træningssejlads for seniorer og juniorer. Juniorer mødes på havnen kl. 16:30. Seniorer mødes på havnen kl. 17:00.", new List<Member>());
    Console.WriteLine(customEventsRepo.GetEvent(2).ToString());
    Console.WriteLine();
    Console.WriteLine("Fjerner event 7");
    Console.WriteLine();
    customEventsRepo.DeleteEvent(2);
    PrintEventsList(customEventsRepo.GetAllCustomEvents());
    Console.WriteLine("\n" + "Tilføjer medlemmer til events" + "\n");
    customEventsRepo.AddParticipantToCustomEvent(5, members.GetMember(1));
    customEventsRepo.AddParticipantToCustomEvent(5, members.GetMember(4));
    customEventsRepo.AddParticipantToCustomEvent(5, members.GetMember(15));
    customEventsRepo.AddParticipantToCustomEvent(5, members.GetMember(3));
    customEventsRepo.AddParticipantToCustomEvent(5, members.GetMember(5));
    Console.WriteLine(customEventsRepo.GetEvent(5).ToString());

}

Console.WriteLine(boats.GetDinghyById(1).ToString());

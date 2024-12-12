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


//////////////////////////////////////////////////////////////////////////////

//Test af Events
CustomEventsRepo customEvents = new CustomEventsRepo();
customEvents.TestEventsList();









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
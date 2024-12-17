using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class BoatsRepo : IBoatsRepo
    {
        public List<Boat> boatList = new List<Boat>();


        public BoatsRepo()
        {
            boatList.Add(new Boat(1, "Optimist ", 2.31, 1.13, 2.25, 35, "Besætning 1 person.", "Optimisten er en af de mest populære enmandsjoller i verden, designet specifikt til unge sejlere op til 15 år. Optimisten er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Boat(2, "Tera  ", 2.87 , 1.23 , 2.37 , 39 , " Besætning 1 person. " , "Teraen er en moderne jolle designet til unge sejlere, typisk fra 8 år og opefter. Teraen er lavet af polyethylen. ", "Ingen Skader "));
            boatList.Add(new Boat(3, "Feva ", 3.64, 1.42, 2.41, 63," Besætning 2 personer. ", " Fevaen er en meget populær jolle, der kan sejles af en eller to personer. Fevaen er lavet af polyethylen. ", "Ingen Skader"));
            boatList.Add(new Boat(4, "Laser ", 4.23, 1.42, 3.38, 59,"Besætning 1 person. ", "Laserjollen er en af de mest populære enmandsjoller i verden, brugt både til afslappet sejlads og kapsejlads. Laserjollen er lavet af glasfiberforstærket plastik. ", "Ingen Skader"));
            boatList.Add(new Boat(5, "Europe ", 3.35, 1.38, 4.8, 60,"Besætning 1 person. ", "Europajollen er en populær enmandsjolle, ideel for sejlere, der er vokset ud af Optimisten. Europajollen er lavet af glasfiber.", "Ingen Skader"));
            boatList.Add(new Boat(6, "Snipe ", 4.72, 1.52, 4.9, 172,"Besætning 2 personer.", "Snipejollen er en klassisk to-personers jolle kendt for sin taktiske sejlads og holdbarhed. Snipejollen er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Boat(7, "Wayfarer ", 4.82, 1.85, 5.2, 167,"Besætning 2-4 personer.", "Wayfarerjollen er en alsidig og robust sejljolle, populær både til kapsejlads, cruising og som træningsbåd. Wayfarerjollen er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Boat(8, "Lynæs ",4 , 1.55, 4.2, 150, "Besætning 1-2 personer.", " Lynæs-jollen er en traditionel dansk båd kendt for sin sødygtighed og robuste konstruktion. Lynæs-jollen er traditionelt lavet af egetræ, men den moderne version er lavet af glasfiber. ", "Ingen Skader"));

        }

        



        // her tilføjer vi en båd til vores båd liste.
        public void AddBoat(Boat boat) 
        {
            boatList.Add(boat);
        }



        // her fjerne vi en båd fra vores båd liste ud fra bådens ID
        public bool RemoveBoat(int id)
        {
            foreach (Boat boats in boatList)
            {
                if (boats.BoatId == id)
                {
                    return boatList.Remove(boats);
                }
            }
            return false;
        }


        // her finder vi en specifik båd ud fra båden ide 

        public Boat? GetBoatById(int id)
        {
            foreach (Boat boats in boatList)
            {
                if (boats.BoatId == id)
                    return boats;
            }
            return null;
        }

        //her finder vi en specifik båd ud fra bådens navn
        public Boat? GetBoatByName(string name)
        {
            foreach (Boat boats in boatList)
            {
                if (boats.BoatName == name)
                    return boats;
            }
            return null;
        }

        // her kan vi finde en båd ud fra den id og derefter updatere specifikie elementer som for eksempel navn
        public Boat UpdateBoats(int BoatId, Boat boats)
        {
            foreach (Boat b in boatList)
            {
                if (b.BoatId == BoatId)
                {
                    b.BoatName = boats.BoatName;
                    b.Lenght = boats.Lenght;
                    b.Width = boats.Width;
                    b.Mast = boats.Mast;
                    b.Weight = boats.Weight;
                    b.Kommentar = boats.Kommentar;
                    b.Description = boats.Description;
                    b.RepairsNeeded = boats.RepairsNeeded;
                    
                }

            }
            return boats;
           
        }

        public List<Boat> GetAllBoats()
        {
            return boatList;
        }




        //// Det her er til at printe vores liste af både ud
        //public void PrintBoats()
        //{
        //    foreach(Boat Boats in boatList)
        //    {
        //        Console.WriteLine(Boats);
        //    }
        //}



    }
}


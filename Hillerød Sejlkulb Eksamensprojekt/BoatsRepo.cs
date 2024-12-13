using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class BoatsRepo
    {
        public List<Boat> boatList = new List<Boat>();


        public BoatsRepo()
        {
            boatList.Add(new Boat(1, "Optimist ", 2.31, 1.13, 2.25, 35, "Crew 1 person.", "The Optimist is one of the most popular singel-handed sailing dinghies in the world, designed specifically for young sailors up to the age of 15. The Optimist is made out of fiberglass. ", "none"));
            boatList.Add(new Boat(2, "Tera  ", 2.87 , 1.23 , 2.37 , 39 , " Crew 1 person. " , "The Tera is a modern dinghy desingned for young sailors, typically from the age 8 and up. The Tera is made out of polyethylene. " , "none "));
            boatList.Add(new Boat(3, "Feva ", 3.64, 1.42, 2.41, 63,"Crew 1-2 people. ", " The Feva is a very popular dinghy that can be sailed by one or two people. The Feva is made out of polyethylene. ", "none"));
            boatList.Add(new Boat(4, "Laser ", 4.23, 1.42, 3.38, 59,"Crew 1 person. ", "The Laser is one of the most popular single-handed dinghies in the world, used for both relaxed sailing and racing. The laser is made out of fiberglass-reinforced plastic ", "none"));
            boatList.Add(new Boat(5, "Europe ", 3.35, 1.38, 4.8, 60,"Crew 1 person. ", "The Europe dinghy is a popular single-handed dinghy ideal for sailors who have outgrown the Optimist. The Europe is made out of fiberglass", "none"));
            boatList.Add(new Boat(6, "Snipe ", 4.72, 1.52, 4.9, 172,"Crew 2 people.", "The Snipe dinghy is a classic two-person dinghy known for its tacticla sailing and durability. The snipe is made out of fiberglass. ", "none"));
            boatList.Add(new Boat(7, "Wayfarer ", 4.82, 1.85, 5.2, 167,"Crew 2-4 people.", "The Wayfarer dinghy is a versatile and robust sailing dinghy, popular for both racing, cruising, and as training boat. The Wayfarer is made out of fiberglass ", "none"));
            boatList.Add(new Boat(8, "Lynæs ",4 , 1.55, 4.2, 150, "Crew 1-2 people.", " The Lynæs dinghy is a traditinal Danish boat known for its seaworthiness and robust construction. The Lynæs is traditinally made out of oak but the modern version is made out of fiberglass. ", "none"));

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
                    b.Comment = boats.Comment;
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


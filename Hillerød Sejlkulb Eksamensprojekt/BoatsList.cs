using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class BoatsList
    {
        public List<Boats> Boat = new List<Boats>();


        public BoatsList()
        {
            Boat.Add(new Boats(1, "boat ", 28.5, 15.2, 9, 72, "description ", "none"));
            Boat.Add(new Boats(2, "boat 2 ", 13.5, 17.2, 18, 78, "desription ", "none"));
            Boat.Add(new Boats(3, "boat 3 ", 21.5, 12.2, 11, 58, "description ", "none"));
            Boat.Add(new Boats(4, "boat 4 ", 12.5, 11.2, 12, 80, "description ", "none"));
            Boat.Add(new Boats(5, "boat 5 ", 48.5, 9.2, 15, 62, "description ", "none"));
            Boat.Add(new Boats(6, "boat 6 ", 8.5, 7.2, 8, 58, "description ", "none"));
        }



        // her tilføjer vi en båd til vores båd liste.
        public void AddBoat(Boats boat) 
        {
            Boat.Add(boat);
        }



        // her fjerne vi en båd fra vores båd liste ud fra bådens ID
        public bool RemoveBoat(int id)
        {
            foreach (Boats boats in Boat)
            {
                if (boats.BoatId == id)
                {
                    return Boat.Remove(boats);
                }
            }
            return false;
        }


        // her finder vi en specifik båd ud fra båden ide 

        public Boats GetBoatById(int id)
        {
            foreach (Boats boats in Boat)
            {
                if (boats.BoatId == id)
                    return boats;
            }
            return null;
        }

        //her finder vi en specifik båd ud fra bådens navn
        public Boats GetBoatByName(string name)
        {
            foreach (Boats boats in Boat)
            {
                if (boats.BoatName == name)
                    return boats;
            }
            return null;
        }

        // her kan vi finde en båd ud fra den id og derefter updatere specifikie elementer som for eksempel navn
        public Boats Update(int BoatId, Boats boats)
        {
            foreach (Boats b in Boat)
            {
                if (b.BoatId == BoatId)
                {
                    b.BoatName = boats.BoatName;
                    b.Lenght = boats.Lenght;
                    b.Width = boats.Width;
                    b.Mast = boats.Mast;
                    b.Weight = boats.Weight;
                    b.Description = boats.Description;
                    b.RepairsNeeded = boats.RepairsNeeded;
                    
                }

            }
            return boats;
           
        }

        // Det her er til at printe vores liste af både ud
        public void PrintBoats()
        {
            foreach(Boats Boats in Boat)
            {
                Console.WriteLine(Boats);
            }
        }



    }
}


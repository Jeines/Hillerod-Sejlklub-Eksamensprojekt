using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            boatList.Add(new Dinghy(1, "Optimist ", 2.31, 1.13, 2.25, 35, "Besætning 1 person.", "Optimisten er en af de mest populære enmandsjoller i verden, designet specifikt til unge sejlere op til 15 år. Optimisten er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Dinghy(2, "Tera  ", 2.87 , 1.23 , 2.37 , 39 , " Besætning 1 person. " , "Teraen er en moderne jolle designet til unge sejlere, typisk fra 8 år og opefter. Teraen er lavet af polyethylen. ", "Ingen Skader "));
            boatList.Add(new Dinghy(3, "Feva ", 3.64, 1.42, 2.41, 63," Besætning 2 personer. ", " Fevaen er en meget populær jolle, der kan sejles af en eller to personer. Fevaen er lavet af polyethylen. ", "Ingen Skader"));
            boatList.Add(new Dinghy(4, "Laser ", 4.23, 1.42, 3.38, 59,"Besætning 1 person. ", "Laserjollen er en af de mest populære enmandsjoller i verden, brugt både til afslappet sejlads og kapsejlads. Laserjollen er lavet af glasfiberforstærket plastik. ", "Ingen Skader"));
            boatList.Add(new Dinghy(5, "Europe ", 3.35, 1.38, 4.8, 60,"Besætning 1 person. ", "Europajollen er en populær enmandsjolle, ideel for sejlere, der er vokset ud af Optimisten. Europajollen er lavet af glasfiber.", "Ingen Skader"));
            boatList.Add(new Dinghy(6, "Snipe ", 4.72, 1.52, 4.9, 172,"Besætning 2 personer.", "Snipejollen er en klassisk to-personers jolle kendt for sin taktiske sejlads og holdbarhed. Snipejollen er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Dinghy(7, "Wayfarer ", 4.82, 1.85, 5.2, 167,"Besætning 2-4 personer.", "Wayfarerjollen er en alsidig og robust sejljolle, populær både til kapsejlads, cruising og som træningsbåd. Wayfarerjollen er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new Dinghy(8, "Lynæs ",4 , 1.55, 4.2, 150, "Besætning 1-2 personer.", " Lynæs-jollen er en traditionel dansk båd kendt for sin sødygtighed og robuste konstruktion. Lynæs-jollen er traditionelt lavet af egetræ, men den moderne version er lavet af glasfiber. ", "Ingen Skader"));
            boatList.Add(new SpeedBoat(9, "Speedster", 12.0, 2.5, 6.8, "Yamaha 300", "Besætning 2-4 personer.", "Speedster er en moderne speedbåd kendt for sin hurtighed og manøvredygtighed. Den er lavet af letvægtsmaterialer og har en kraftig motor.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(10, "WaveRunner", 10.0, 2.0, 5.5, "Mercury 250", "Besætning 2-3 personer.", "WaveRunner er designet til høj hastighed og komfort. Den har en kraftig motor og er ideel til vandsport.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(11, "Thunderbolt", 14.0, 3.0, 7.2, "Honda 350", "Besætning 3-5 personer.", "Thunderbolt er en luksuriøs speedbåd med høj ydeevne og avancerede funktioner. Perfekt til lange ture.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(12, "SeaRider", 11.0, 2.3, 6.0, "Suzuki 280", "Besætning 2-4 personer.", "SeaRider kombinerer hastighed og stabilitet, hvilket gør den ideel til både afslapning og eventyr.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(13, "AquaJet", 13.0, 2.8, 6.5, "Evinrude 320", "Besætning 3-4 personer.", "AquaJet er kendt for sin hurtige acceleration og glatte sejlads. Den er perfekt til hurtige ture.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(14, "FlashWave", 9.0, 1.8, 4.8, "Tohatsu 220", "Besætning 1-2 personer.", "FlashWave er en kompakt speedbåd, ideel til korte ture og hurtige manøvrer.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(15, "Hurricane", 15.0, 3.2, 7.8, "Johnson 400", "Besætning 4-6 personer.", "Hurricane er en kraftfuld speedbåd designet til ekstreme forhold og høj hastighed.", "Ingen Skader"));
            boatList.Add(new SpeedBoat(16, "JetStream", 10.0, 2.1, 5.2, "Nissan 260", "Besætning 2-3 personer.", "JetStream er en alsidig speedbåd, der tilbyder både hastighed og komfort til en bred vifte af aktiviteter.", "Ingen Skader"));
        }

        



        // her tilføjer vi en båd til vores båd liste.
        public void AddBoat(Boat boat) 
        {
            boatList.Add(boat);
        }
        //tilføjer jolle  til liste 
        public void AddDinghy(Dinghy dinghy)
        {
            boatList.Add(dinghy);
        }
        // tilføjer jolle til list 
        public void AddSpeedBoat(SpeedBoat speedBoat)
        {
            boatList.Add(speedBoat);
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
        //fjerner en jolle fra listen ud fra ID 
        public bool RemoveDinghy(int id)
        {
            foreach (Dinghy dinghys in boatList)
            {
                if (dinghys.BoatId == id)
                {
                    return boatList.Remove(dinghys);
                }
            }
            return false;
        }
        //fjerner en speedbåd fra listen ud fra ID 
        public bool RemovesSpeedBoat(int id)
        {
            foreach (SpeedBoat speedBoat in boatList)
            {
                if (speedBoat.BoatId == id)
                {
                    return boatList.Remove(speedBoat);
                }
            }
            return false;
        }


        // her finder vi en specifik jolle ud fra båden ide 

        public Boat? GetBoatById(int id)
        {
            foreach (Boat boats in boatList)
            {
                if (boats.BoatId == id)
                    return boats;
            }
            return null;
        }
        // metode til at finde en jolle ud fra id 
        public Dinghy? GetDinghyById(int id)
        {
            foreach (Dinghy dinghy in boatList)
            {
                if (dinghy.BoatId == id)
                    return dinghy;
            }
            return null;
        }
        // metode til at finde en speedbåd ud fra id 
        public SpeedBoat? GetSpeedById(int id)
        {
            foreach (SpeedBoat speedBoat in boatList)
            {
                if (speedBoat.BoatId == id)
                    return speedBoat;
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
        // finder en specifik jolle ud fra navn
        public Boat? GetDinghyByName(string name)
        {
            foreach (Dinghy dinghy in boatList)
            {
                if (dinghy.BoatName == name)
                    return dinghy;
            }
            return null;
        }

        // finder en specifik speedbåd ud fra navn
        public SpeedBoat? GetSpeedBoatByName(string name)
        {
            foreach (SpeedBoat speedBoat in boatList)
            {
                if (speedBoat.BoatName == name)
                    return speedBoat;
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
                    b.Weight = boats.Weight;
                    b.Kommentar = boats.Kommentar;
                    b.Description = boats.Description;
                    b.RepairsNeeded = boats.RepairsNeeded;
                    
                }

            }
            return boats;
           
        }
        // her kan vi finde en båd ud fra den id og derefter updatere specifikie elementer som for eksempel navn
        public Boat UpdateDinghy(int BoatId, Dinghy dinghy)
        {
            foreach (Dinghy d in boatList)
            {
                if (d.BoatId == BoatId)
                {
                    
                    d.BoatName = dinghy.BoatName;
                    d.Lenght = dinghy.Lenght;
                    d.Width = dinghy.Width;
                    d.Mast = dinghy.Mast;
                    d.Weight = dinghy.Weight;
                    d.Kommentar = dinghy.Kommentar;
                    d.Description = dinghy.Description;
                    d.RepairsNeeded = dinghy.RepairsNeeded;

                }

            }
            return dinghy;

        }

        // her kan vi finde en båd ud fra den id og derefter updatere specifikie elementer som for eksempel navn
        public Boat UpdateSpeedBoat(int BoatId, SpeedBoat speedBoat)
        {
            foreach (SpeedBoat s in boatList)
            {
                if (s.BoatId == BoatId)
                {
                    s.BoatName = speedBoat.BoatName;
                    s.Lenght = speedBoat.Lenght;
                    s.Width = speedBoat.Width;
                    s.Weight = speedBoat.Weight;
                    s.OutBoardEngin = speedBoat.OutBoardEngin;
                    s.Kommentar = speedBoat.Kommentar;
                    s.Description = speedBoat.Description;
                    s.RepairsNeeded = speedBoat.RepairsNeeded;

                }

            }
            return speedBoat;
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


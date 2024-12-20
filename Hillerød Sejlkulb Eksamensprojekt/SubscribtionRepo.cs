using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class SubscribtionRepo
    {
        public List<Subscribtion> subList = new List<Subscribtion>();

        // en liste over medlemskabernes priser
        public SubscribtionRepo()
        {
            subList.Add(new Subscribtion(1, "Junior medlem ( Alderen 0-18 år)", 750.00));
            subList.Add(new Subscribtion(2, "Junior medlem inkl. Opbevarings plads ", 950.00));
            subList.Add(new Subscribtion(3, "Senior medlem", 1100.00));
            subList.Add(new Subscribtion(4, "Senior medlem inkl. Opbevarings plads", 750.00));
            subList.Add(new Subscribtion(5, "Familie (Til hele husstanden )", 1500.00));
            subList.Add(new Subscribtion(6, "Båd plads ", 400.00));
            subList.Add(new Subscribtion(7, "Måndlig udgift", 250.00));
            subList.Add(new Subscribtion(8, "Tildmellings gebyr", 150.00));
        }
       // Hvis sejlklubben vil tilføje flere subscribtion til klubben
        public void Add(SubscribtionRepo subscribtion)
        {
            subscribtion.Add(subscribtion);
        }

        public Subscribtion GetSubscribtion(int id)
        {
            foreach ( Subscribtion sub  in subList)
            {
                if (sub.Id == id)
                    return sub;
            }
            return null!;
        }



       // fjerne en subscribtion fra subscribtion listen
        public bool RemoveSubscription(int Id)
        {
            foreach (Subscribtion subscribtion in subList)
            {
                if (subscribtion.Id == Id)
                {
                    return subList.Remove(subscribtion);
                }
            }
            return false;
        }


        // her laver vi en methode som kan bruges til at hente alle Subscribtions fra vores List<Subscribtion>
        public List<Subscribtion> GetAllSubscribtions()
        {
            return subList;
        }
       
        // kan opdatere id, medlemsskabs type og pris
        public Subscribtion Update(int Id, Subscribtion subscribtion) 
        { 
        foreach (Subscribtion s in subList)
            {
                if (s.Id == Id)
                {
                    s.Id = subscribtion.Id;
                    s.SubscriptionType = subscribtion.SubscriptionType;
                    s.Price = subscribtion.Price;
                }
            }
            return subscribtion;
        }



    }
}

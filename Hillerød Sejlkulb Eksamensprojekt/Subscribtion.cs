using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Subscribtion
    {
        public int Id { get; set; }
        public string SubscriptionType { get; set; }
        public double Price { get; set; }

        public Subscribtion(int id, string subscriptionType, double price)
        {
            Id = id;
            SubscriptionType = subscriptionType;
            Price = price;

        }
        public override string ToString()
        {
            //return " ID" + Id + "Subscribtion type" + SubscriptionType + " Price " + Price;

            return $"Subscribtion Id: {Id} \nSubscribtion Type: {SubscriptionType} \nPrice: {Price} Kr.  \n";

        }
    }
}

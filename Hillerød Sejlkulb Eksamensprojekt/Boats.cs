using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Boats
    {
        public string BoatName {  get; set; }
        public int BoatId {  get; set; }
        public string Description { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Mast { get; set; }
        public int Weight { get; set; }
        public string RepairsNeeded { get; set; }

        public Boats(int boatId, string name, double lenght, double width, double mast, int weight, string description, string repairsNeeded)
        {
            BoatName = name;
            BoatId = boatId;
            Lenght = lenght;   
            Width = width;
            Mast = mast;
            Weight = weight;
            Description = description;
            RepairsNeeded = repairsNeeded;
        }

        public override string ToString() { return "Boat Id" + BoatId + "Name" + BoatName + "Boat lenght" + Lenght + "Boat width " + Width + "Mast" + Mast + "Boat weight" + Weight + "Boat description" + Description + "Repairs needed" + RepairsNeeded; }
        
           
     


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Boat
    {
        public string BoatName {  get; set; }
        public int BoatId {  get; set; }
        public string Description { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public string RepairsNeeded { get; set; }

        public string Kommentar { get; set; }

        public Boat(int boatId, string name, double lenght, double width, double weight, string Comment, string description, string repairsNeeded)
        {
            BoatName = name;
            this.BoatId = boatId;
            Lenght = lenght;   
            Width = width;
            Weight = weight;
            Kommentar = Comment;
            Description = description;
            RepairsNeeded = repairsNeeded;
        }

        //public override string ToString() { return "Boat Id" + BoatId + "Name" + BoatName + "Boat lenght" +  Lenght + "Meter " + "Boat width " + Width + "Meter " + "Mast" + Mast + "Meter " + "Boat weight" + Weight + "Kg" + "Infomation" + Comment +"Boat description"  + Description + "Repairs needed" + RepairsNeeded; }


        public override string ToString()
        {
            return $"Båd Id: ({BoatId}) |  Båd Navn: {BoatName}  |  Båd Længde: {Lenght}M  | Båd Brede : {Width}M  |  Båd Vægt: {Weight}Kg  \nBåd Infomation: ({Kommentar}) \nBåd Beskrivelse: {Description}  \nReparation: ({RepairsNeeded})";
        }


    }
}

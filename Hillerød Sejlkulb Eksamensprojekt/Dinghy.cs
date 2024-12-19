using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class Dinghy : Boat
    {
        public Dinghy(int boatId, string name, double lenght, double width, double mast, int weight, string Comment, string description, string repairsNeeded) : base(boatId, name, lenght, width, weight, Comment, description, repairsNeeded)
        {
            Mast = mast;
        }

        public double Mast { get; set; }

        public override string ToString()
        {
          return $"Båd Id: ({BoatId}) |  Båd Navn: {BoatName}  |  Båd Længde: {Lenght}M  | Båd Brede : {Width}M  |  Båd Vægt: {Weight}Kg |  Mast: {Mast}  \nBåd Infomation: ({Comment}) \nBåd Beskrivelse: {Description}  \nReparation: ({RepairsNeeded})";
        }
    }

}
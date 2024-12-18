using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public class SpeedBoat : Boat
    {

        public SpeedBoat(int boatId, string name, double lenght, double width, double weight, string outBoardEngin, string Comment, string description, string repairsNeeded) : base(boatId, name, lenght, width, weight, Comment, description, repairsNeeded)
        {
            OutBoardEngin = outBoardEngin;
        }
        public string OutBoardEngin {  get; set; }


        public override string ToString()
        {
            return $"Båd Id: ({BoatId}) |  Båd Navn: {BoatName}  |  Båd Længde: {Lenght}M  | Båd Brede : {Width}M  |  Båd Vægt: {Weight}Kg |  Udboard motor: {OutBoardEngin} speed   \nBåd Infomation: ({Kommentar}) \nBåd Beskrivelse: {Description}  \nReparation: ({RepairsNeeded})";
        }


    }
}

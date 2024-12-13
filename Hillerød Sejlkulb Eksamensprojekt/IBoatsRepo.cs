using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_Sejlkulb_Eksamensprojekt
{
    public interface IBoatsRepo
    {
        public void AddBoat(Boat boat);
        public bool RemoveBoat(int id);
        public Boat? GetBoatById(int id);
        public Boat? GetBoatByName(string name);
        public Boat UpdateBoats(int BoatId, Boat boats);
        public List<Boat> GetAllBoats();





    }
}

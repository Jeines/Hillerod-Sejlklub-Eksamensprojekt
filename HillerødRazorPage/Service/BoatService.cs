using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Service
{
    public class BoatService
    {
        private List<Boat> _boats;

        private BoatsRepo _boatRepo = new BoatsRepo();

        public BoatService()
        {
            _boats = _boatRepo.GetAllBoats();
        }

        public void AddBoat(Boat boat)
        {
            _boats.Add(boat);
        }

        public List<Boat> GetBoats()
        {
            return _boats;
        }
    }
}

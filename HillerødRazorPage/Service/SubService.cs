using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Service
{
    public class SubService
    {
        private List<Subscribtion> _sub;

        private SubscribtionRepo _subRepo = new SubscribtionRepo();

        public SubService()
        {
            _sub = _subRepo.GetAllSubscribtions();
        }

        public void AddSub(Subscribtion sub)
        {
            _sub.Add(sub);
        }

        public List<Subscribtion> GetSub()
        {
            return _sub;
        }
    }
}

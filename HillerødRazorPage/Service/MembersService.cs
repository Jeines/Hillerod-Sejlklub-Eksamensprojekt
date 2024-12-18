using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Service
{
    public class MembersService
    {
        private List<Member> _member;

        private MembersRepo _membersRepo = new MembersRepo();

        public MembersService()
        {
            _member = _membersRepo.GetAllMembers();
        }

        public void AddMember(Member member)
        {
            _member.Add(member);
        }

        public List<Member> GetMember()
        {
            return _member;
        }
    }
}

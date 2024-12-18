using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Pages.MembersPage
{
    public class GetAllMembersModel : PageModel
    {
        private MembersService _memberService;

        public GetAllMembersModel(MembersService memberService)
        {
            _memberService = memberService;
        }

        public List<Hillerød_Sejlkulb_Eksamensprojekt.Member> Members { get; private set; }

        public void OnGet()
        {
            Members = _memberService.GetMember();
        }





    }
}

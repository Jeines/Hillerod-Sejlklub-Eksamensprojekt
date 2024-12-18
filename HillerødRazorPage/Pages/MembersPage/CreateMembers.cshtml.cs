using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødRazorPage.Pages.MembersPage
{
    public class CreateMembersModel : PageModel
    {
        private MembersService _memberService;

        public CreateMembersModel(MembersService memberService)
        {
            _memberService = memberService;
        }

        [BindProperty]
        public Hillerød_Sejlkulb_Eksamensprojekt.Member member { get; set; }

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _memberService.AddMember(member);
            return RedirectToPage("GetAllMembers");
        }
    }
}

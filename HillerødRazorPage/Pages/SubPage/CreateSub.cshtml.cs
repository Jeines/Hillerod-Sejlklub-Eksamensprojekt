using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødRazorPage.Pages.SubPage
{
    public class CreateSubModel : PageModel
    {
        private SubService _subService;

        public CreateSubModel(SubService subService)
        {
            _subService = subService;
        }

        [BindProperty]
        public Hillerød_Sejlkulb_Eksamensprojekt.Subscribtion Sub { get; set; }

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

            _subService.AddSub(Sub);
            return RedirectToPage("GetAllSubs");
        }
    }
}

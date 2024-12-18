using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Pages.BoatPage
{
    public class CreateBoatModel : PageModel
    {
        private BoatService _boatService;

        public CreateBoatModel(BoatService boatService)
        {
            _boatService = boatService;
        }

        [BindProperty]
        public Hillerød_Sejlkulb_Eksamensprojekt.Boat Boat { get; set; }

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

            _boatService.AddBoat(Boat);
            return RedirectToPage("GetAllBoats");
        }
    }
}

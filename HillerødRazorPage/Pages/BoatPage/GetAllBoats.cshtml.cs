using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejlkulb_Eksamensprojekt;

namespace HillerødRazorPage.Pages.Boat
{
    public class GetAllBoatsModel : PageModel
    {
        private BoatService _boatService;

        public GetAllBoatsModel(BoatService boatService)
        {
            _boatService = boatService;
        }

        public List<Hillerød_Sejlkulb_Eksamensprojekt.Boat> Boats { get; private set; }

        public void OnGet()
        {
            Boats = _boatService.GetBoats();
        }



            
        
   }
}

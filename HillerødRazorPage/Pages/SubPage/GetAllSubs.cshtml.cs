using HillerødRazorPage.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødRazorPage.Pages.SubPage
{
    public class GetAllSubsModel : PageModel
    {
        private SubService _subService;

        public GetAllSubsModel(SubService subService)
        {
            _subService = subService;
        }

        public List<Hillerød_Sejlkulb_Eksamensprojekt.Subscribtion> Subscription { get; private set; }

        public void OnGet()
        {
            Subscription = _subService.GetSub();
        }





    }
}

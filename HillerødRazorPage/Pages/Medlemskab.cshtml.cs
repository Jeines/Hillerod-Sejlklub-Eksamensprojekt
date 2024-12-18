using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødRazorPage.Pages
{
    public class MedlemModel : PageModel
    {
        private readonly ILogger<MedlemModel> _logger;

        public MedlemModel(ILogger<MedlemModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt
{
    public class DyreDetaljerModel : PageModel
    {
        private IDyreService _dyreService;
        [BindProperty] //Binder UI s� data fra form kan overf�res til Dyre-properties
        public Dyr Dyr { get; private set; }

        public DyreDetaljerModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }
        public IActionResult OnGet(int ID)
        {
         Dyr = _dyreService.GetDyrID(ID);
            if (Dyr == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

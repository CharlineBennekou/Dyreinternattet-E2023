using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt
{
    public class EditDyrModel : PageModel
    {
        private IDyreService _dyreService;


        [BindProperty] //Binder UI så data fra form kan overføres til Dyre-properties
        public Models.Dyreoversigt.Dyr Dyr { get; set; }

        public EditDyrModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }

        public IActionResult OnGet(int id)
        {
            Dyr = _dyreService.GetDyrID(id);
            if (Dyr == null)
                return RedirectToPage("/Error"); //NotFound er ikke defineret endnu
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _dyreService.UpdateDyr(Dyr);
            return RedirectToPage("GetAllDyr");
        }



    }
}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt
{
    public class DeleteDyrModel : PageModel
    {
        private IDyreService _dyreService;


        [BindProperty] //Binder UI så data fra form kan overføres til Dyre-properties
        public Models.Dyreoversigt.Dyr Dyr { get; set; }

        public DeleteDyrModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }

        public IActionResult OnGet(int id)
        {
            Dyr = _dyreService.GetDyrID(id);
            if (Dyr == null)
                return RedirectToPage("/Error"); 
            return Page();
        }

        public IActionResult OnPost()
        {
            Models.Dyreoversigt.Dyr deletedDyr = _dyreService.DeleteDyr(Dyr.ID);
            if (deletedDyr == null)
                return RedirectToPage("/Error"); 
            return RedirectToPage("GetAllDyr");
        }













    }
}

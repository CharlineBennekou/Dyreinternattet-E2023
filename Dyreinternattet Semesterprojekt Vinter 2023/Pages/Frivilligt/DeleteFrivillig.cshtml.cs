using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    public class DeleteFrivilligModel : PageModel
    {

		private IFrivilligService _frivilligService;

		[BindProperty] // BindProperty blevet brugt til at indeholde en instans af Frivillige-klassen.
		public Models.Frivilligt.Frivillige Frivillige { get; set; }

		public DeleteFrivilligModel(IFrivilligService frivilligService) //Service initialiseres vha. dependency injection
        {
			_frivilligService = frivilligService;
		}

		public IActionResult OnGet(int id)      // HTTP GET-handler, der henter frivillige-oplysninger baseret på det givne ID
		{
			Frivillige = _frivilligService.GetFriv(id);
			if (Frivillige == null)
				return RedirectToPage("/NotFound"); // Hvis indmeldingen ikke eksisterer, omdiriger til NotFound-siden

			return Page();
		}

		// HTTP POST-handler, der udfører sletning af frivillig baseret på ID'et og omdirigerer til en anden side
		public IActionResult OnPost()
		{
			Models.Frivilligt.Frivillige deletedFriv = _frivilligService.DeleteFriv(Frivillige.ID);
			if (deletedFriv == null)
				return RedirectToPage("/Error");
			return RedirectToPage("GetAllFrivillige"); // Hvis sletning var vellykket, omdiriger brugeren til GetAllFrivillige-siden.
		}

    }
}

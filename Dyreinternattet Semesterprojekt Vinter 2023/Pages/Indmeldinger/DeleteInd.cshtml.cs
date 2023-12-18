using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    public class DeleteIndModel : PageModel
    {
		private IIndService _indService;

		[BindProperty] // BindProperty blevet brugt til at indeholde en instans af Indmelding-klassen
		public Models.Indmeldinger.Indmelding Indmelding { get; set; } 

		public DeleteIndModel(IIndService indService) //Service initialiseres vha. dependency injection
        {
			_indService = indService;
		}

		// HTTP GET-handler, der henter indmeldings-oplysninger baseret på det givne ID
		public IActionResult OnGet(int id)
		{
			Indmelding = _indService.GetIndmelding(id);
			if (Indmelding == null)
				return RedirectToPage("/NotFound"); // Hvis indmeldingen ikke eksisterer, omdiriger til NotFound-siden

			return Page();
		}

		// HTTP POST-handler, der udfører sletning af indmelding baseret på ID'et og omdirigerer til en anden side
		public IActionResult OnPost()
		{
			Models.Indmeldinger.Indmelding deletedInd = _indService.DeleteIndmelding(Indmelding.ID);
			if (deletedInd == null)
				return RedirectToPage("/Error");
			return RedirectToPage("GetAllIndmelding"); // Hvis sletning var vellykket, omdiriger brugeren til GetAllIndmelding-siden

		}
	}
}

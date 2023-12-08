using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    public class DeleteIndModel : PageModel
    {
		private IIndService _indService;

		[BindProperty]
		public Models.Indmeldinger.Indmelding Indmelding { get; set; } //husk mappe (slet kommentar efter)

		public DeleteIndModel(IIndService indService)
		{
			_indService = indService;
		}

		public IActionResult OnGet(int id)
		{
			Indmelding = _indService.GetIndmelding(id);
			if (Indmelding == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return Page();
		}

		public IActionResult OnPost()
		{
			Models.Indmeldinger.Indmelding deletedInd = _indService.DeleteIndmelding(Indmelding.ID);
			if (deletedInd == null)
				return RedirectToPage("/Error");
			return RedirectToPage("GetAllIndmelding");
		}
	}
}

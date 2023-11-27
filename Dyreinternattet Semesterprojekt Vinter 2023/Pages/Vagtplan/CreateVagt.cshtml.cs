using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagt
{
    public class CreateVagtModel : PageModel
    {
		private IVagtService _vagtService;

		public CreateVagtModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
		}

		[BindProperty]
		public Models.Vagtplan.Vagt Vagt { get; set; }

		public IActionResult OnGet()
		{
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_vagtService.AddVagt(Vagt);
			return RedirectToPage("GetAllVagter");
		}
    }
}

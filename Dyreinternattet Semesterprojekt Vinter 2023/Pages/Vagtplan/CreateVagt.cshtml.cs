using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagt
{
    public class CreateVagtModel : PageModel
    {
		private IVagtService _vagtService;

		public CreateItemModel(IVagtService itemService)
		{
			_itemService = itemService;
		}

		[BindProperty]
		public Models.Item Item { get; set; }

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

			_itemService.AddVagt(Vagt);
			return RedirectToPage("GetAllVagter");
		}
    }
}

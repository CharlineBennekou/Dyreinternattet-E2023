using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagtplan
{
    public class EditVagtModel : PageModel
    {
        private IVagtService _vagtService;
        [BindProperty]
		public Models.Vagtplan.Vagt Vagt { get; set; }
        public EditVagtModel(IVagtService vagtService)
        {
            _vagtService = vagtService;
        }

        public SelectList StartTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.StartTidOptions());
        }

        public SelectList SlutTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.SlutTidOptions());
        }
        public IActionResult OnGet(int id)
        {
            Vagt = _vagtService.GetVagt(id);
            if (Vagt == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_vagtService.UpdateVagt(Vagt);
			return RedirectToPage("GetAllVagter");
		}

	}
}

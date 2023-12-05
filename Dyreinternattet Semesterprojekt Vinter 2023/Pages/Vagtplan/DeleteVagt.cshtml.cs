using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagtplan
{
	public class DeleteVagtModel : PageModel
	{
		private IVagtService _vagtService;

		[BindProperty]
		public Models.Vagtplan.Vagt Vagt { get; set; }

		public DeleteVagtModel(IVagtService vagtService)
		{
			_vagtService = vagtService;
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
            Models.Vagtplan.Vagt deletedVagt = _vagtService.DeleteVagt(Vagt.Id);
            if (deletedVagt == null)
                return RedirectToPage("/Error");
            return RedirectToPage("GetAllDyr");
        }
    }
}

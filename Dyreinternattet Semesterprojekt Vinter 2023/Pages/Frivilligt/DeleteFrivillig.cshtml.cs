using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    public class DeleteFrivilligModel : PageModel
    {

		private IFrivilligService _frivilligService;

		[BindProperty] 
		public Models.Frivilligt.Frivillige Frivillige { get; set; }

		public DeleteFrivilligModel(IFrivilligService frivilligService) //Service initialiseres vha. dependency injection
        {
			_frivilligService = frivilligService;
		}

		public IActionResult OnGet(int id)
		{
			Frivillige = _frivilligService.GetFriv(id);
			if (Frivillige == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			return Page();
		}

		public IActionResult OnPost()
		{
			Models.Frivilligt.Frivillige deletedFriv = _frivilligService.DeleteFriv(Frivillige.ID);
			if (deletedFriv == null)
				return RedirectToPage("/Error");
			return RedirectToPage("GetAllFrivillige");
		}

    }
}

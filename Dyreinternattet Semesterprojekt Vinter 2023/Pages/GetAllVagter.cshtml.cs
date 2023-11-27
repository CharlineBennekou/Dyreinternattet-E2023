using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages
{
    public class GetAllVagterModel : PageModel
    {

		public List<Models.Vagtplan.Vagt>? Vagter { get; private set; }
		public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Pages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagtplan
{
    public class GetAllVagterModel : PageModel
    {
        private IVagtService _vagtService;

        public GetAllVagterModel(IVagtService vagtService)
        {
            _vagtService = vagtService;
        }

        public List<Models.Vagtplan.Vagt>? Vagter { get; private set; }
        public void OnGet()
        {
            Vagter = _vagtService.GetVagter();

        }
    }
}

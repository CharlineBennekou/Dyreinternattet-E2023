using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagt
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

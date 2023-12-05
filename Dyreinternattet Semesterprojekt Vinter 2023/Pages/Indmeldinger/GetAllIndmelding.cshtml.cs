using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    public class CreateIndmeldingModel : PageModel
    {

        private IIndService _indService;


        public CreateIndmeldingModel(IIndService indService) //Dependency Injection
        {
            _indService = indService;
        }


        public List<Models.Indmeldinger.Indmelding>? AdoptList { get; private set; }

        public void OnGet()
        {
            AdoptList = _indService.GetInd();
        }

    }
}

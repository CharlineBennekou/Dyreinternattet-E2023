using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Microsoft.AspNetCore.Authorization;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    [Authorize]

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

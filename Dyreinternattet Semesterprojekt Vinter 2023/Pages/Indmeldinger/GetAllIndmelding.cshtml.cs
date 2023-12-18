using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    [Authorize] //Kun adgang til siden hvis brugeren har autorisation


    public class CreateIndmeldingModel : PageModel
    {

        private IIndService _indService;


        public CreateIndmeldingModel(IIndService indService) //Service initialiseres vha. dependency injection
        {
            _indService = indService;
        }


        // Liste til at indeholde indmeldinger, der vises på siden
        public List<Models.Indmeldinger.Indmelding>? AdoptList { get; private set; }

        public void OnGet() // OnGet-metode, der kaldes ved HTTP GET-anmodninger
        {
            AdoptList = _indService.GetInd();
        }

    }
}

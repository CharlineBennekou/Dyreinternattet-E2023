using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Pages;
using System.Net.Http.Headers;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt
{
    public class GetAllDyr : PageModel
    {
        private IDyreService _dyreService; //Instance field som kan referere til en service
        public GetAllDyr(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }
        public List<Models.Dyreoversigt.Dyr> Dyreliste { get; private set; } //Property som kan referere til en liste af dyr

        public void OnGet() //Dyrelisten henter data fra servicen og logiken for GET-andmodnind
        {
            Dyreliste = _dyreService.GetDyr();
        }


        // Dette er en atrtribut som binder egenskaben til modellen for automatisk inputh�ndtering.
        [BindProperty]
        public string SearchString { get; set; }


        // Denne metode aktiveres, n�r der foretgaes en Post-anmodning til denne side for s�gning.
        public IActionResult OnPostSearch() // Logiken for POST-andmodning
        {
            //Kalder p� search(_dyreService.Search) til at s�ge efter
            //elemente baseret p� SearchSrtring og konverterer resultet til en liste
            Dyreliste = _dyreService.Search(SearchString).ToList();

            // Retunere siden, efter s�gningen er udf�rt
            return Page();
        }
    }

        

    
}

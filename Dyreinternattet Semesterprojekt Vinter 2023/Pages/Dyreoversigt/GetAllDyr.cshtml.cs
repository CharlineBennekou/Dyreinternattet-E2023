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

        public void OnGet() //Dyrelisten henter data fra servicen
        {
            Dyreliste = _dyreService.GetDyr();
        }


        [BindProperty]
        public string SearchString { get; set; }

        public IActionResult OnPostNameSearch()
        {
            Dyreliste = _dyreService.NameSearch(SearchString).ToList();
            return Page();
        }


        //public IActionResult OnPostDyrFilter()
        //{
        //    Dyreliste = _dyreService.DyrFilter.ToList();
        //    return Page();
        //}

        public IActionResult 


    }
}

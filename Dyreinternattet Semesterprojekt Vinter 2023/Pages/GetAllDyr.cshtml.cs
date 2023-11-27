using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Pages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models
{
    public class Pages_GetAllDyr : PageModel
    { 
        private IObjectService _dyreService;
        public Pages_GetAllDyr(DyreService dyreService)
        {
            _dyreService = dyreService;
        }
        public List<Dyr> Dyreliste { get; private set; }
        public void OnGet()
        {
            Dyreliste = DyreService.GetDyreliste();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models
{
    public class DyreoversigtModel : PageModel
    {

        // Oprettede en liste af Dyr som består af dens construktor
        public List<Dyr> Dyreliste { get; private set; } = new List<Dyr>()
        {
            // Dyr bliver oprettet af contruktor fra dyr
            new Dyr("Fido", "Husky-mix", 4, 42, true, false),
            new Dyr("Hans", "Huskat", 9, 5.8, true, false)
        };
        public void OnGet()
        {
        }
    }
}

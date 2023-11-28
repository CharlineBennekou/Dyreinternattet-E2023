using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagt
{
    public class CreateVagtModel : PageModel
    {
        private IVagtService _vagtService;

        public CreateVagtModel(IVagtService vagtService)
        {
            _vagtService = vagtService;
        }
        public SelectList MedarbejderOptions()
        {
            return new SelectList(MockVagter.MedarbejderOptions(), "Medarbejder", "Medarbejder.Name");
        }
        public SelectList StartTidOptions()
        {
            return new SelectList(MockVagter.StartTidOptions());
        }

        public SelectList SlutTidOptions()  
        {
            return new SelectList(MockVagter.SlutTidOptions());
        }
        [BindProperty]
        public Models.Vagtplan.Vagt Vagt { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _vagtService.AddVagt(Vagt);
            return RedirectToPage("GetAllVagter");
        }
    }
}
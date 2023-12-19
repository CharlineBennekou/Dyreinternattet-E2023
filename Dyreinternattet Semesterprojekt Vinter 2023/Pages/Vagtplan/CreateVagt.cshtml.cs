using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagtplan
{
    [Authorize]
    public class CreateVagtModel : PageModel
    {
        private readonly IVagtService _vagtService;

        [BindProperty]
        public Models.Vagtplan.Vagt Vagt { get; set; } = new Models.Vagtplan.Vagt();
        public SelectList MedarbejderOptions { get; set; }

        public CreateVagtModel(IVagtService vagtService)
        {
            _vagtService = vagtService;
            MedarbejderOptions = new SelectList(Data.MockVagter.MedarbejderOptions(), nameof(Vagt.Medarbejder.MedarbejderName), nameof(Vagt.Medarbejder.MedarbejderName), nameof(Vagt.Medarbejder.MedarbejderEmail));

        }

        public SelectList StartTidOptions()
        {
            return new SelectList(Data.MockVagter.StartTidOptions());
        }

        public SelectList SlutTidOptions()
        {
            return new SelectList(Data.MockVagter.SlutTidOptions());
        }

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

            // Get the selected Medarbejder from the dropdown
            var selectedMedarbejderName = Vagt.AssignedMedarbejder.MedarbejderName;

            // Retrieve the complete Medarbejder with all information
            var selectedMedarbejder = Data.MockVagter.MedarbejderOptions()
                .Where(m => m.MedarbejderName == selectedMedarbejderName)
                .FirstOrDefault();

            if (selectedMedarbejder == null)
            {
                // Handle the case where selectedMedarbejder is not found
                // You might want to add proper error handling or redirect back to the page with an error message
                return Page();
            }

            // Set AssignedMedarbejder with the selected Medarbejder
            Vagt.AssignedMedarbejder = selectedMedarbejder;

            // Add the Vagt
            _vagtService.AddVagt(Vagt);

            return RedirectToPage("GetAllVagter");
        }
    }
}
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagt
{
    public class CreateVagtModel : PageModel
    {
        #region Properties
        private readonly MedarbejderService _medarbejderService;
        private readonly IVagtService _vagtService;
        public List<Medarbejder> MedarbejderOptions { get; set; }

        [BindProperty]
        public Models.Vagtplan.Vagt Vagt { get; set; }
        #endregion

        #region Constructor
        public CreateVagtModel(MedarbejderService medarbejderService, IVagtService vagtService)
        {
            _medarbejderService = medarbejderService;
            _vagtService = vagtService;
        }
        #endregion

        #region Methods
        public SelectList StartTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.StartTidOptions());
        }

        public SelectList SlutTidOptions()
        {
            return new SelectList(Models.Vagtplan.Vagt.SlutTidOptions());
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            Console.WriteLine("1");
            if (!ModelState.IsValid)
            {
                Console.WriteLine("2");
                return Page();
                Console.WriteLine("3");
            }

            // Update the Vagt Medarbejder property based on the selected value in the dropdown
            Vagt.Medarbejder = MedarbejderOptions.Find(m => m.Name == Vagt.Medarbejder.Name);

            // Now, you can use the Vagt object to create a new Vagt in your service
            _vagtService.AddVagt(Vagt);

            // Redirect to the page showing all Vagter after creating a new one
            return RedirectToPage("GetAllVagter");
        }
        #endregion
    }
}
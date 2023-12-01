using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Vagtplan
{
    public class CreateVagtModel : PageModel
    {
        private readonly IMedarbejderService _medarbejderService;
        private readonly IVagtService _vagtService;

        //public CreateVagtModel(MedarbejderService medarbejderService, IVagtService vagtService)
        //{
        //    _medarbejderService = medarbejderService;
        //    _vagtService = vagtService;
        //}

        //public List<Medarbejder> MedarbejderOptions { get; set; }

        [BindProperty]
        public Vagt Vagt { get; set; }
        public SelectList Medarbejderliste { get; set; }

        public CreateVagtModel(IMedarbejderService medarbejderService, IVagtService vagtService) //Initialisering af services
        {
            _medarbejderService = medarbejderService;
            _vagtService = vagtService;
        }

        public SelectList StartTidOptions()
        {
            return new SelectList(MockVagter.StartTidOptions());
        }

        public SelectList SlutTidOptions()
        {
            return new SelectList(MockVagter.SlutTidOptions());
        }

        public void OnGet()
        {
            Medarbejderliste = new SelectList(_medarbejderService.GetMedarbejdere(), "Navn");
            Vagt= new Vagt();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Fejl");
                return Page();
                
            }
Console.WriteLine("Success");
            // Now, you can use the Vagt object to create a new Vagt in your service
            _vagtService.AddVagt(Vagt);

            // Redirect to the page showing all Vagter after creating a new one
            return RedirectToPage("GetAllVagter");
        }
    }
}
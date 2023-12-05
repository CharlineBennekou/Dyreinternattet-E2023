using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    public class CreateIndmeldingerModel : PageModel
    {

        //Dyr propeties
        [BindProperty]
        [Required(ErrorMessage = "Vælg venligst hvilket dyr du har")]
        public string DyrType { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et navn på dyret")]
        public string DyrName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst racen på dyret")]
        public string Race { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en alder på dyret")]
        public int Age { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst hvor meget dyret vejer")]
        public double Weight { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Vælg venligst et svar")]
        public string IsVac { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Skriv venligst en kort beskrivelse på dyret")]
        public string DyrInfo { get; set; }



        //Ejer propeties
        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et navn")]
        public string EjerName { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en adresse")]
        public string EjerAddress { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et postnummer")]
        public int EjerPost { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et tlf-nummer")]
        public string EjerTlf { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en gyldig email")]
        public string EjerMail { get; set; }



        private IIndService _indService;

        public CreateIndmeldingerModel(IIndService indService)
        {
            _indService = indService;
        }

        [BindProperty]
        public Models.Indmeldinger.Indmelding Indmelding { get; set; }

        public string errorMessage = "";



        public IActionResult OnGet()
        {
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Alle felter er ikke blevet udfyldt";
                return Page();
            }
            _indService.AddInd(Indmelding);
            return RedirectToPage("AfterInd");


        }

    }
}

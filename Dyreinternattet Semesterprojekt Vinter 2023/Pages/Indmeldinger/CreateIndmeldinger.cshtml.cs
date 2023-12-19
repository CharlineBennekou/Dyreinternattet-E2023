using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Indmeldinger
{
    public class CreateIndmeldingerModel : PageModel
    {



        // Der er brugt BindProperty-attributter for at tilknytte modelens egenskaber til HTML-formularen
        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et navn p� dyret")] // Der er tilf�jet validering ved hj�lp af Required-attributten
        public string DyrName { get; set; }


        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst racen p� dyret")]
        public string Race { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en alder p� dyret")]
        public int Age { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst hvor meget dyret vejer")]
        public double Weight { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "V�lg venligst et svar")]
        public string IsVac { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Skriv venligst en kort beskrivelse p� dyret")]
        public string DyrInfo { get; set; }



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

        [BindProperty] // BindProperty blevet brugt til at indeholde en instans af Indmelding-klassen.
        public Models.Indmeldinger.Indmelding Indmelding { get; set; }

        private IIndService _indService;

        public CreateIndmeldingerModel(IIndService indService) //Service initialiseres vha. dependency injection
        {
            _indService = indService;
        }




        // Fejlmeddelelsesvariabel der bruges til at vise brugeren der er fejl ved indsendelse af formularen
        public string errorMessage = "";



        public IActionResult OnGet() // Metode der h�ndterer HTTP GET-anmodninger og returnerer siden
        {
            return Page();
        }


        public IActionResult OnPost() // Metode der h�ndterer HTTP POST-anmodninger, udf�rer validering og gemmer indmeldingen, hvis dataen er korrekt
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Alle felter er ikke blevet udfyldt";
                return Page();
            }
            // Hvis validering er korrekt tilf�jes indmeldingen ved hj�lp af indService og brugeren sendes til en anden side.
            _indService.AddInd(Indmelding);
            return RedirectToPage("AfterInd");
        }

    }
}

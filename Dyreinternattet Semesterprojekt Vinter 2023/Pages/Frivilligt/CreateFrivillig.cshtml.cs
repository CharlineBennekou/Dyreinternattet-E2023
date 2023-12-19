using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    public class CreateFrivilligModel : PageModel
    {

        [BindProperty]  // BindProperty-attributter til at binde modelens egenskaber til HTML-formularen med validering
        [Required(ErrorMessage = "Indtast venligst et navn")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en fødselsdato")]
        public string Birthday { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en adresse")]
        public string Address { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et postnummer")]
        public int Postnummer { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et tlf-nummer")]
        public string Tlf { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en gyldig email")]
        public string Mail { get; set; }

        [BindProperty] 
        [Required(ErrorMessage = "Skriv venligst en kort beskrivelse af dig selv")]
        public string Description { get; set; }


        private IFrivilligService _frivilligService;

        public CreateFrivilligModel(IFrivilligService frivilligService) //Service initialiseres vha. dependency injection
        {
            _frivilligService = frivilligService;
        }


        [BindProperty] // BindProperty blevet brugt til at indeholde en instans af Frivillige-klassen.
        public Models.Frivilligt.Frivillige Frivillige { get; set; }


        // Fejlmeddelelsesvariabel der bruges til at vise brugeren der er fejl ved indsendelse af formularen
        public string errorMessage = "";

        public IActionResult OnGet() // Metode der håndterer HTTP GET-anmodninger og returnerer siden
        {
            return Page();
        }


        public IActionResult OnPost() // HTTP POST-handler, der udfører validering og gemmer den nye frivillige, hvis dataen er korrekt
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Alle felter er ikke belvet udfyldt";
                return Page();
            }
            // Hvis validering er korrekt tilføjes frivillige ved hjælp af frivilligService og brugeren sendes til en anden side.
            _frivilligService.AddFrivillig(Frivillige);
            return RedirectToPage("AfterFriv");
        }


    }
}

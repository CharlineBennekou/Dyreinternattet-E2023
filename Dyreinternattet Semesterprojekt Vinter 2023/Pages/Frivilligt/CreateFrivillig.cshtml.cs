using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    public class CreateFrivilligModel : PageModel
    {

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst et navn")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en fødselsdato")]
        public string Birthday { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Indtast venligst en adresse")]
        public string Address { get; set; }

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

        public CreateFrivilligModel(IFrivilligService frivilligService)
        {
            _frivilligService = frivilligService;
        }


        [BindProperty]
        public Models.Frivilligt.Frivillige Frivillige { get; set; }


        public string errorMessage = "";

        public IActionResult OnGet()
        {
            return Page();
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Alle felter er ikke belvet udfyldt";
                return Page();
            }

            _frivilligService.AddFrivillig(Frivillige);
            return RedirectToPage("AfterFriv");
        }


    }
}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt

{
    [Authorize]
    public class CreateDyrModel : PageModel
    {
		private IDyreService _dyreService;
        [BindProperty] //Binder UI så data fra form kan overføres til Dyre-properties
        public Models.Dyreoversigt.Dyr Dyr { get; set; }



        public CreateDyrModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }


      

        public IActionResult OnGet()
        {
            var userClaims = User.Claims;
            foreach (var claim in userClaims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            _dyreService.AddDyr(Dyr);
            return RedirectToPage("GetAllDyr");

        }

       





    }
}

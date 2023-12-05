using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using System;
using Microsoft.AspNetCore.Hosting;


namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt

{
    public class CreateDyrModel : PageModel
    {
		private IDyreService _dyreService;
        [BindProperty] //Binder UI s� data fra form kan overf�res til Dyre-properties
        public Models.Dyreoversigt.Dyr Dyr { get; set; }



        public CreateDyrModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
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
            _dyreService.AddDyr(Dyr);
            return RedirectToPage("GetAllDyr");

        }

       





    }
}

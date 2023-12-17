using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Dyreoversigt
{
    public class DyreDetaljerModel : PageModel
    {
        private IDyreService _dyreService;
        [BindProperty] //Binder UI s� data fra form kan overf�res til Dyre-properties
        public Dyr Dyr { get; private set; }

        public DyreDetaljerModel(IDyreService dyreService) //Service initialiseres vha. dependency injection
        {
            _dyreService = dyreService;
        }
        public IActionResult OnGet(int ID)
        {
            Dyr = _dyreService.GetDyrID(ID);
            if (Dyr == null)
            {
                return NotFound();
            }
            return Page();
        }
        //public IActionResult OnPost() //n�r man uploader et billede
        //{
        //    if (Dyr != null && Dyr.ImageFile != null && Dyr.ImageFile.Length > 0)
        //    {
        //        var imagePath = $"/images/animals/{Guid.NewGuid().ToString()}{Path.GetExtension(Dyr.ImageFile.FileName)}"; //generer et unikt filnavn for billedet vha. Guid
        //        var imagePathOnDisk = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", imagePath); //Dette kombinerer vores egen filepath med det unikke filnavn

        //        using (var stream = new FileStream(imagePathOnDisk, FileMode.Create)) //Laver en filestream som opretter filen p� den path vi fik ovenfra
        //        {
        //            Dyr.ImageFile.CopyTo(stream); //Overf�rer uploaded billede til filen
        //        }
        //        Dyr.ImagePath = imagePath; //Opdaterer vores dyr's imagepath property til at v�re lig med den imagepath vi fik tidligere
        //        _dyreService.UpdateDyrImage(Dyr);
        //        return Page();

        //    }
        //    return Page();
        //}
    }
}

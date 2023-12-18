using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    [Authorize]//Kun adgang til siden hvis brugeren har autorisation
    public class GetAllFrivilligeModel : PageModel
    {

        private IFrivilligService _frivilligService;


        public GetAllFrivilligeModel(IFrivilligService frivilligService) //Service initialiseres vha. dependency injection
        {
            _frivilligService = frivilligService;
        }

        // Liste til at indeholde frivillige, der vises på siden
        public List<Models.Frivilligt.Frivillige>? FrivList { get; private set; }

        public void OnGet() // OnGet-metode, der kaldes ved HTTP GET-anmodninger
        {
            FrivList = _frivilligService.GetFrivillig();
        }






    }
}

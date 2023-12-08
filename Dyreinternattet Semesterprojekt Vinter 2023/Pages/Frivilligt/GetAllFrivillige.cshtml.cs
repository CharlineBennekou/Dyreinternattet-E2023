using Dyreinternattet_Semesterprojekt_Vinter_2023.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Frivilligt
{
    public class GetAllFrivilligeModel : PageModel
    {

        private IFrivilligService _frivilligService;

        //public List<Models.Frivillige> DyrList  { get; private set; } = new List<Models.Frivillige>()


        public GetAllFrivilligeModel(IFrivilligService frivilligService) //Dependency Injection
        {
            _frivilligService = frivilligService;
        }

        public List<Models.Frivilligt.Frivillige>? FrivList { get; private set; }

        public void OnGet()
        {
            FrivList = _frivilligService.GetFrivillig();
        }






    }
}
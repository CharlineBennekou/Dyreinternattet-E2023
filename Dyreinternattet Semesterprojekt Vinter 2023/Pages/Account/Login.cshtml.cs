using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Account;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }

       
    }
}

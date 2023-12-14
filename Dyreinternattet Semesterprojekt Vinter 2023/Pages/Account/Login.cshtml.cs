using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Account;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost() //Når man logger ind
        {
            Console.WriteLine("onpost:");
            if (ModelState.IsValid) //tjekker om modelstate er valid
            {
                if (Credential.UserName == "admin" && Credential.Password == "kode") //tjekker om username og password == vores username og kode
                {
					var claims = new List<Claim> //laver en ny liste af claims
				    {
					    new Claim(ClaimTypes.Name, Credential.UserName), //Claimer at username == name
                    
                    };
					var identity = new ClaimsIdentity(claims, "MyCookieAuthenticationScheme"); //Skaber en ny identitet med vores liste af claims + vores authenticationscheme vi satte op i program.cs

					var principal = new ClaimsPrincipal(identity); //Principal repræsenterer vores nuværende user og den enkapsulerer vores identitet(som består af claims+authenticationscheme)

                    HttpContext.SignInAsync("MyCookieAuthenticationScheme", principal); // Metode som logger brugeren ind. Bruger vores authenticcationscheme og principal som argument.
                                                                                        // Metoden sætter en session op og en cookie som indeholder brugerens identitet

                    Console.WriteLine("Logged ind");
                    return RedirectToPage("/index"); //returnerer os til frontpage efter succesfuld login
                    

                }
                ModelState.AddModelError(string.Empty, "invalid login attempt"); //error hvis credentials ikke matcher vores program
            }
            
            return null;
        }

       
    }
}

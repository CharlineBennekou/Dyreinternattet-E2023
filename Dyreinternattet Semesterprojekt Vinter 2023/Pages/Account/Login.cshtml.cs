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
					var claims = new List<Claim> //laver en ny liste af claims om vores user
				    {
					    new Claim(ClaimTypes.Name, Credential.UserName), //Vi har kun et claim og det er at deres navn = username
                    
                    };
					var identity = new ClaimsIdentity(claims, "MyCookieAuthenticationScheme"); //Skaber en identitet som repræsenterer vores user i denne session

					var principal = new ClaimsPrincipal(identity); //Principal repræsenterer vores nuværende user og den enkapsulerer vores users identitet

                    HttpContext.SignInAsync("MyCookieAuthenticationScheme", principal); // Metode som logger user ind.
                                                                                        // Metoden sætter en session op og issuer en cookie

                    Console.WriteLine("Logged ind");
                    return RedirectToPage("/index"); //returnerer os til frontpage efter succesfuld login
                    

                }
                ModelState.AddModelError(string.Empty, "invalid login attempt"); //error hvis credentials ikke matcher
            }
            
            return null;
        }

       
    }
}

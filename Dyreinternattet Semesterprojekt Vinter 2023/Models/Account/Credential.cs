using System.ComponentModel.DataAnnotations;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Account
{
    public class Credential
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class MedarbejderService
    {
        public List<Medarbejder> GetMedarbejdere()
        {
            
            return new List<Medarbejder>
        {
            new Medarbejder("John Doe", "john@example.com", 12345678),
            new Medarbejder("Jane Doe", "jane@example.com", 87654321),
            new Medarbejder("Joey Moe", "joey@example.com", 13264312),
            // Add more Medarbejder objects as needed
        };
        }
    }

}

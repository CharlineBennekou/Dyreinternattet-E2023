using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockMedarbejder
    {
        private static List<Medarbejder> _medarbejderListe = new List<Medarbejder>()
        {
        new Medarbejder("John Doe", "john@example.com", 12345678),
        new Medarbejder("Jane Doe", "jane@example.com", 87654321),
        new Medarbejder("Bob Smith", "bob@example.com", 55555555),
        new Medarbejder("Sofus Jensen", "sofus@example.com", 98765432),
        new Medarbejder("Erik Andersen", "erik@example.com", 45678901),
        new Medarbejder("Sofie Nielsen", "sofie@example.com", 11112222),
        new Medarbejder("Chris Hansen", "chris@example.com", 99998888)
        };
        public static List<Medarbejder> GetMockMedarbejder()
        {
            return _medarbejderListe;
        }
    }
}

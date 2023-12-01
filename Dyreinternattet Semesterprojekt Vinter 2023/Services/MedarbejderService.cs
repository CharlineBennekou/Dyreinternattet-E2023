using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class MedarbejderService : IMedarbejderService
    {
        private List<Medarbejder> _medarbejdere;
        public MedarbejderService()
        {
            _medarbejdere = new List<Medarbejder>()
            {
            new Medarbejder("John Doe", "john@example.com", 12345678),
            new Medarbejder("Jane Doe", "jane@example.com", 87654321),
            new Medarbejder("Joey Moe", "joey@example.com", 13264312),

            };
        }
        public void AddMedarbejder(Medarbejder medarbejder)
        {
            throw new NotImplementedException();
        }

        public Medarbejder DeleteMedarbejder(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Medarbejder> GetMedarbejdere()
        {

            return _medarbejdere;
        }

        public Medarbejder GetMedarbejderID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMedarbejder(Medarbejder medarbejder)
        {
            throw new NotImplementedException();
        }
    }

}

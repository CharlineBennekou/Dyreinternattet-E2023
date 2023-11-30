using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class MedarbejderService
    {
        //public List<Medarbejder> GetMedarbejdere()
        //{

        //    return new List<Medarbejder>
        //{
        //    new Medarbejder("John Doe", "john@example.com", 12345678),
        //    new Medarbejder("Jane Doe", "jane@example.com", 87654321),
        //    new Medarbejder("Joey Moe", "joey@example.com", 13264312),

        //};
        //}

        private JsonFileMedarbejderService JsonFileMedarbejderService { get; set; } //Auto property for Jsonfilservice

        private List<Medarbejder> _medarbejderListe; //Instance field kan referere til en liste af dyr

        public MedarbejderService(JsonFileMedarbejderService jsonFileMedarbejderService) //Når DyreService constructes, henter dyrelisten data fra jsonfil
        {
            JsonFileMedarbejderService = jsonFileMedarbejderService;
            //_dyreliste = MockDyr.GetMockDyr();
            //_medarbejderListe = JsonFileMedarbejderService.GetJsonMedarbejder().ToList();
        }
        public MedarbejderService() //Backup hvis json ikk virker
        {
            _medarbejderListe= MockMedarbejder.GetMockMedarbejder();
        }

        public void AddMedarbejder(Medarbejder medarbejder)
        {
            _medarbejderListe.Add(medarbejder);
            //JsonFileMedarbejderService.SaveJsonMedarbejder(_medarbejderListe);
        }
        public List<Medarbejder> GetMedarbejder() //metode til at returnere dyrelisten
        {
            return _medarbejderListe;
        }
    }

}

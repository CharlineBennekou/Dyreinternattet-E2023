using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class IndService : IIndService //Bruger interface
    {

        private JsonFileIndService JsonFileIndService { get; set; } //Auto property for Jsonfilservice

        private List<Indmelding> _adoptList; //Instance field kan referere til en liste af indmeldinger


        public IndService(JsonFileIndService jsonFileIndService) //Når IndService constructes, henter adoptlisten data fra jsonfil
        {
            JsonFileIndService = jsonFileIndService;
            //_adoptList = MockInd.GetMockInd();
            _adoptList = JsonFileIndService.GetJsonInd().ToList();
        }

        public IndService() //Backup hvis json ikk virker
        {
            _adoptList = MockInd.GetMockInd();
        }


        // Metode til at tilføje en ny indmelding og gemme data i JSON-filen.
        public void AddInd(Indmelding indmelding)
        {
            _adoptList.Add(indmelding);
            JsonFileIndService.SaveJsonInd(_adoptList);
        }


        // Metode til at hente en indmelding ud fra ID.
        public Indmelding GetIndmelding(int id)
        {
            foreach (Indmelding indmelding in _adoptList)
            {
                if (indmelding.ID == id)
                    return indmelding;
            }

            return null;
        }


        // Metode til at slette en indmelding ud fra ID og gemme ændringer i JSON-filen
        public Indmelding DeleteIndmelding(int? indId)
        {
            Indmelding IndToBeDeleted = null;

            foreach (Indmelding indmelding in _adoptList)
            {
                if (indmelding.ID == indId)
                {
                    Console.WriteLine("Indmelding fundet:");
                    Console.WriteLine(indmelding);
                    IndToBeDeleted = indmelding;
                    break;

                }
            }
            if (IndToBeDeleted != null)
            {
                _adoptList.Remove(IndToBeDeleted);
                JsonFileIndService.SaveJsonInd(_adoptList);
            }

            return IndToBeDeleted;
        }


        // Metode til at hente en liste af alle indmeldinger
        public List<Indmelding> GetInd()
        {
            return _adoptList;
        }

    }
}

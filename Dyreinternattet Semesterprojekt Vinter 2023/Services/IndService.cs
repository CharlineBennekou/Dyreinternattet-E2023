using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class IndService :IIndService
    {

        private JsonFileIndService JsonFileIndService { get; set; } //Auto property for Jsonfilservice

        private List<Indmelding> _adoptList;


        public IndService(JsonFileIndService jsonFileIndService) //Når IndService constructes, henter dyrelisten data fra jsonfil
        {
            JsonFileIndService = jsonFileIndService;
            //_adoptList = MockInd.GetMockInd();
            _adoptList = JsonFileIndService.GetJsonInd().ToList();
        }

        public IndService() //Backup hvis json ikk virker
        {
            _adoptList = MockInd.GetMockInd();
        }


        public void AddInd(Indmelding indmelding)
        {
            _adoptList.Add(indmelding);
            JsonFileIndService.SaveJsonInd(_adoptList);
        }

        public List<Indmelding> GetInd()
        {
            return _adoptList;
        }

    }
}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class FrivilligService : IFrivilligService
    {

        private JsonFileFrivilligService JsonFileFrivilligService { get; set; } //Auto property for Jsonfilservice

        private List<Frivillige> _frivList; //Instance field kan referere til en liste af frivillige


        public FrivilligService(JsonFileFrivilligService jsonFileFrivilligService) //Når FrivilligeService constructes, henter frivlisten data fra jsonfil
        {
            JsonFileFrivilligService = jsonFileFrivilligService;
            //_frivList = MockFrivillig.GetMockFrivillig();
            _frivList = JsonFileFrivilligService.GetJsonFrivillig().ToList();

        }

        public FrivilligService() //Backup hvis json ikk virker
        {
            _frivList = MockFrivillig.GetMockFrivillig();
        }


        public void AddFrivillig(Frivillige frivillige)
        {
            _frivList.Add(frivillige);
            JsonFileFrivilligService.SaveJsonFrivillig(_frivList);
        }

        public List<Frivillige> GetFrivillig()
        {
            return _frivList;
        }


    }
}

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


		public Frivillige GetFriv(int id)
		{
			foreach (Frivillige frivillige in _frivList)
			{
				if (frivillige.ID == id)
					return frivillige;
			}

			return null;
		}


		public Frivillige DeleteFriv(int? friveId)
		{
			Frivillige FrivToBeDeleted = null;

			foreach (Frivillige frivillige in _frivList)
			{
				if (frivillige.ID == friveId)
				{
					Console.WriteLine("Frivillig fundet:");
					Console.WriteLine(frivillige);
					FrivToBeDeleted = frivillige;
					break;

				}
			}
			if (FrivToBeDeleted != null)
			{
				_frivList.Remove(FrivToBeDeleted);
				JsonFileFrivilligService.SaveJsonFrivillig(_frivList);
			}

			return FrivToBeDeleted;
		}



		public List<Frivillige> GetFrivillig()
        {
            return _frivList;
        }


    }
}

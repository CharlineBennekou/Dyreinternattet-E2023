using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class FrivilligService : IFrivilligService //Bruger interface
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


        // Metode til at tilføje en ny frivillig og gemme data i JSON-filen
        public void AddFrivillig(Frivillige frivillige) 
        {
            _frivList.Add(frivillige);
            JsonFileFrivilligService.SaveJsonFrivillig(_frivList);
        }


        // Metode til at hente en frivillig ud fra ID
        public Frivillige GetFriv(int id)
		{
			foreach (Frivillige frivillige in _frivList)
			{
				if (frivillige.ID == id)
					return frivillige;
			}

			return null;
		}


        // Metode til at slette en frivillig ud fra ID og gemme ændringer i JSON-filen
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



        // Metode til at hente en liste af alle frivillige
        public List<Frivillige> GetFrivillig()
        {
            return _frivList;
        }


    }
}

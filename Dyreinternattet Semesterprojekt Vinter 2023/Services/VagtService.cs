using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public class VagtService : IVagtService
	{
		private JsonFileVagtService JsonFileVagtService { get; set; } 
		private List<Vagt> _vagter;
		public VagtService(JsonFileVagtService jsonFileVagtService) //Når DyreService constructes, henter dyrelisten data fra jsonfil
		{
			//_dyreliste = MockDyr.GetMockDyr();
			JsonFileVagtService = jsonFileVagtService;
			_vagter = JsonFileVagtService.GetJsonVagt().ToList();
		}
		public VagtService()
		{
			_vagter = MockVagter.GetMockVagter();	
		}
		public void AddVagt(Vagt vagt)
		{
			_vagter.Add(vagt);
			JsonFileVagtService.SaveJsonVagt(_vagter);
		}	
		public List<Vagt> GetVagter()
		{
			return _vagter;
		}

        public void UpdateVagt(Vagt vagt)
        {
            if (vagt != null) //Opdaterer kun hvis input ikke er null
            {
                foreach (Vagt v in _vagter) //Tjekker alle dyr
                {
                    if (v.ID == vagt.ID) //Hvis ID matcher, opdateres info
                    {
                        v.SlutTid = v.SlutTid;
						v.StartTid	= v.StartTid;
						v.Medarbejder = v.Medarbejder;

                    }
                }
                JsonFileVagtService.SaveJsonVagt(_vagter); //Listen gemmes i json bagefter
            }
        }

        public Vagt DeleteVagt(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

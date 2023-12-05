using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public class VagtService : IVagtService
	{
		private List<Vagt> _vagter;
		private JsonFileVagtService JsonFileVagtService { get; set; }

        public VagtService(JsonFileVagtService jsonFileVagtService)
        {
            JsonFileVagtService = jsonFileVagtService;
			//_vagter = MockVagter.GetMockVagter();
			_vagter = JsonFileVagtService.GetJsonVagter().ToList();
		}

		public VagtService()
		{

			_vagter = MockVagter.GetMockVagter();
			//_vagter = JsonFileVagtService.GetJsonVagter().ToList();
		}
		public void AddVagt(Vagt vagt)
		{
			_vagter.Add(vagt);
			JsonFileVagtService.SaveJsonVagter(_vagter);
		}

		public Vagt GetVagt(int id)
		{
			foreach (Vagt vagt in _vagter)
			{
				if (vagt.Id == id)
					return vagt;
			}

			return null;
		}
        public void UpdateVagt(Vagt vagt)
        {
            if (vagt != null) //Opdaterer kun hvis input ikke er null
            {
                foreach (Vagt v in _vagter) //Tjekker alle dyr
                {
                    if (v.Id == v.Id) //Hvis ID matcher, opdateres info
                    {
                        Console.WriteLine(vagt);
                        Console.WriteLine("fundet");
						v.AssignedMedarbejder = vagt.AssignedMedarbejder;
						v.StartTid = vagt.StartTid;
						v.SlutTid = vagt.SlutTid;




                    }

                }
                JsonFileVagtService.SaveJsonVagter(_vagter); //Listen gemmes i json bagefter
            }
            Console.WriteLine("dyr er null");
        }

        public Vagt DeleteVagt(int? vagtId)
		{

			foreach (Vagt vagt in _vagter)
			{
				if (vagt.Id == vagtId)
				{
					_vagter.Remove(vagt);

				}
			}

			return null;
		}
		public List<Vagt> GetVagter() { return _vagter; }

	}
}

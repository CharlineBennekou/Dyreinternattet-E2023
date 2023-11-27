using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public class VagtService
	{
		private List<Vagt> _vagter;

		public VagtService()
		{
			_vagter = MockVagter.GetMockVagter();	
		}
		public void AddVagt(Vagt vagt)
		{
			_vagter.Add(vagt);
		}
		
		public List<Vagt> GetVagter()
		{
			return _vagter;
		}
	}
}

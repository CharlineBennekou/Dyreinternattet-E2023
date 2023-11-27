using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public interface IVagtService
	{
		List<Vagt> GetVagts();
		void AddVagt(Vagt vagt);
	}
}

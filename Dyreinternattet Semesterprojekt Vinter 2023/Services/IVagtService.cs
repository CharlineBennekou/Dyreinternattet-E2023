using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public interface IVagtService
	{
		List<Vagt> GetVagter();
		void AddVagt(Vagt vagt);

		//void UpdateVagt(Vagt vagt);
		Vagt GetVagt(int id);
		Vagt DeleteVagt(int? id);
    }
}

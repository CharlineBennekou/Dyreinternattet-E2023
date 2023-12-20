using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IFrivilligService //Interface som bruges af firvilligService
    {
        List<Frivillige> GetFrivillig();
        void AddFrivillig(Frivillige frivillige);
		Frivillige GetFriv(int id);
		Frivillige DeleteFriv(int? friveId);

	}
}

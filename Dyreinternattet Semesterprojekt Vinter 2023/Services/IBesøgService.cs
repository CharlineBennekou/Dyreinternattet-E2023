using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Kalender;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IBesøgService
    {
        List<Besøg> GetBesøg();
        void AddBesøg(Besøg besøg);
        void UpdateBesøg(Besøg besøg);
        Besøg DeleteBesøg(int? id);
    }
}

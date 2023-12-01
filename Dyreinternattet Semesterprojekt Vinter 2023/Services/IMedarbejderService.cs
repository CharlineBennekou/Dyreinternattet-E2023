using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IMedarbejderService
    {
        List<Medarbejder> GetMedarbejdere();
        Medarbejder GetMedarbejderID(int id);
        void AddMedarbejder(Medarbejder medarbejder);
        void UpdateMedarbejder(Medarbejder medarbejder);
        Medarbejder DeleteMedarbejder(int? id);
    }
}

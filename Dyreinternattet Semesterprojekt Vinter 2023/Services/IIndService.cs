using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IIndService
    {

        List<Indmelding> GetInd();

        void AddInd(Indmelding indmelding);

        Indmelding GetIndmelding(int id);

        Indmelding DeleteIndmelding(int? indId);


    }
}

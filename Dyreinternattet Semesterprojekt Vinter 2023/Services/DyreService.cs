using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class DyreService : IObjectService
    {
        public List<Dyr> Dyreliste { get; }

        public DyreService()
        {
            Dyreliste = MockDyr.GetMockDyr();
        }

        public List<Dyr> GetDyreliste()
        {
            return Dyreliste;
        }
    }
}

using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class DyreService : IObjectService
    {
        public List<Dyr> Dyreliste { get; }

        public Dyreservice()
        {
            Dyreliste = MockDyr.GetMockDyr();
        }

        public List<Dyr> GetPizzas()
        {
            return Dyreliste;
        }
    }
}

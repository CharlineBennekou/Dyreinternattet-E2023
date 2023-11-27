using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class DyreService : IDyreService //Bruger interface
    {
        private List<Dyr> _dyreliste; //Instance field kan referere til en liste af dyr

        public DyreService() //Når DyreService constructes, henter dyrelisten data
        {
            _dyreliste = MockDyr.GetMockDyr();
        }

        public List<Dyr> GetDyr() //metode til at returnere dyrelisten
        {
            return _dyreliste;
        }
    }
}

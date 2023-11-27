using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockDyr
    {

        private static List<Dyr> _dyreliste = new List<Dyr>()
            {
            new Dyr("Fido", "Husky-mix", 4, 42, true, false),
            new Dyr("Hans", "Huskat", 9, 5.8, true, false)
            };
        public static List<Dyr> GetMockDyr()
        {
            return _dyreliste;
        }
    }
}

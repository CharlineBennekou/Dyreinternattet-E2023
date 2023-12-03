 using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockDyr
    {

        private static List<Dyr> _dyreliste = new List<Dyr>()
            {
            new Dyr(Dyr.DyreArt.Hund, "Fido", "Husky-mix", 4, 42, true, false, "/images/image1.png", " Mød Fido, en fascinerende hund med en rigdom af karaktertræk. I en alder af 5 år har Fido oplevet verden med en skarp nysgerrighed og legesyge."),
            new Dyr(Dyr.DyreArt.Kanin,"Hans", "Huskat", 9, 5.8, true, false, "/images/image1.png", " Mød Hans, en fascinerende hund med en rigdom af karaktertræk. I en alder af 5 år har Hans oplevet verden med en skarp nysgerrighed og legesyge.")
            };
        public static List<Dyr> GetMockDyr()
        {
            return _dyreliste;
        }
    }
}

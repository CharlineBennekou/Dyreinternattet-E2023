using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockInd
    {

        private static List<Indmelding> _adoptList = new List<Indmelding>()
        {
            new Indmelding ("Kanin", "Bibi", "Løvehovede", 5, 3.5, true , "Den elsker gulerødder",
                "Ole Jensen", "Lindelindevej 13", 2865, "52618188", "ole@gmail.com"),

            new Indmelding ("Kat", "Miser", "Ragdoll", 2, 10, false, "Den slår mig dagen lang",
                "Ilse Jakobsen", "Ghettoplanen 24", 4260, "78318188", "ilseghetto@gmail.com")
        };

        public static List<Indmelding> GetMockInd()
        {

            return _adoptList;

        }

    }
}

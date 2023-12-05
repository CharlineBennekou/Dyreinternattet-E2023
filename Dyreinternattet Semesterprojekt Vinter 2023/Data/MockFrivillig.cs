using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockFrivillig
    {
        private static List<Frivillige> _frivList = new List<Frivillige>()
        {
            new Frivillige("Stine", "2000-11-28", "Kongevej 22 Hellerup 4565", "35278071", "stinehellerup@gmail.com", "Jeg elsker dyr."),
            new Frivillige("Thomas", "1995-02-15", "Jordbærdgade 84, Næstved 7055", "65748394", "thomasjordbær@gmail.com", "Jeg har boet på en gård hele mit liv.")
        };


        public static List<Frivillige> GetMockFrivillig()
        {

            return _frivList;

        }

    }
}

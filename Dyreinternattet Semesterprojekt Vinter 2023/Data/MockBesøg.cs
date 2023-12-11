using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Kalender;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
    public class MockBesøg
    {
        private static List<Besøg> _besøgsListe = new List<Besøg>()
        {
            new Besøg(startTid: "8:00", slutTid: "10:00", note: "Jens Jensen"),
            new Besøg(startTid: "12:00", slutTid: "14:00", note: "Maria Hansen"),
            new Besøg(startTid: "14:00", slutTid: "16:00", note: "Ib Ibsen")
        };

        public static List<Besøg> GetMockBesøg() 
        {
            return _besøgsListe;
        }
    }
}

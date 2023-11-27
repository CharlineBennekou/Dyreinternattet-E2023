namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Kanin : Dyr
    {
        // Kanin inheriter fra Dyr klassse

        public Kanin()
        {
        }

        public Kanin(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret, string mad)
            : base(navn, race, alder, vægt, vaccineStatus, erAdopteret, mad)
        {
        }
    }
}

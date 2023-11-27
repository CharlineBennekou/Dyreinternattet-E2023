namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Kat : Dyr
    {
        // Kat inheriter fra Dyr klasse
        public Kat()
        {
        }

        public Kat(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret)
            : base(navn, race, alder, vægt, vaccineStatus, erAdopteret)
        {
        }
    }
}

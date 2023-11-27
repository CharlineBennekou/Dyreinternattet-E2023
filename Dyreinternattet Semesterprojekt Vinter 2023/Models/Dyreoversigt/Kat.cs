namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Kat : Dyr
    {
        public Kat()
        {
        }

        public Kat(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret, string mad)
            : base(navn, race, alder, vægt, vaccineStatus, erAdopteret, mad)
        {
        }
    }
}

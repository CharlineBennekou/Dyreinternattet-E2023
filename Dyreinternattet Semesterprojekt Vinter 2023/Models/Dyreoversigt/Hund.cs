namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Hund : Dyr
    {
        //Hund inheriter fra Dyr klasse.

        public Hund()
        {
        }

        public Hund(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret, string mad)
            : base(navn, race, alder, vægt, vaccineStatus, erAdopteret, mad)
        {
        }
    }
}

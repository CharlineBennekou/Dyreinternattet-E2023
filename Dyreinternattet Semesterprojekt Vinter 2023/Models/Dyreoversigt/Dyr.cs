namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Dyr
    {
        static int nextId = 1;
        public int ID { get; }
        public string Navn { get; set; }
        public string Race { get; set; }
        public double Alder { get; set; }
        public double Vægt { get; set; }
        public bool VaccineStatus { get; set; }
        public bool ErAdopteret { get; set; }
        public string Mad { get; set; }

         



        public Dyr()
        {
            ID = nextId++;
        }
        

        public Dyr(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret, string mad)
        {
            ID = nextId++;
            Navn = navn;
            Race = race;
            Alder = alder;
            Vægt = vægt;
            VaccineStatus = vaccineStatus;
            ErAdopteret = erAdopteret;
            Mad = mad;
        }

     

    }


}

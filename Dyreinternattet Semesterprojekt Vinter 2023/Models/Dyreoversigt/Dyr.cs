namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Dyr
    {
        //Id'et bliver aktomatisk givet og alle Id bliver unikke
        static int nextId = 1;
        public int ID { get; }
        public string Navn { get; set; }
        public string Race { get; set; }
        public double Alder { get; set; }
        public double Vægt { get; set; }
        public bool VaccineStatus { get; set; }
        public bool ErAdopteret { get; set; }

         


        //Den defaulte constructor skal have et Id ligemeget hvad
        public Dyr()
        {
            ID = nextId++;
        }
        

        public Dyr(string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret)
        {
            ID = nextId++;
            Navn = navn;
            Race = race;
            Alder = alder;
            Vægt = vægt;
            VaccineStatus = vaccineStatus;
            ErAdopteret = erAdopteret;
        }

     

    }


}

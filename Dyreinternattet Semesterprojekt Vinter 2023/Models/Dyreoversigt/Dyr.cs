namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Dyr
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Race { get; set; }
        public double Alder { get; set; }
        public double Vægt { get; set; }
        public bool VaccineStatus { get; set; }
        public bool ErAdopteret { get; set; }
        public string Mad { get; set; }
        public kalender Kalender { get; set; }
    }
}

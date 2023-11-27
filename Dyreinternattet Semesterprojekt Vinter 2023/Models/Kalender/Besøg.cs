namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Kalender
{
    public class Besøg
    {
       

        public int StartTid { get; set; }
        public int SlutTid { get; set; }
        public string Note { get; set; }

         public Besøg()
        {
        }

        public Besøg(int startTid, int slutTid, string note)
        {
            StartTid = startTid;
            SlutTid = slutTid;
            Note = note;
        }
    }



}

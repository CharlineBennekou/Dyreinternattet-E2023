namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Kalender
{
    public class Besøg
    {
        static int nextId = 1;
        public int Id { get; }
        public string StartTid { get; set; }
        public string SlutTid { get; set; }
        public string Note { get; set; }

         public Besøg()
         {
         }

        public Besøg(string startTid, string slutTid, string note)
        {
            Id = nextId++;
            StartTid = startTid;
            SlutTid = slutTid;
            Note = note;
        }
    }



}

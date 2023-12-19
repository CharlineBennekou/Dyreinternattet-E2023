namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
        #region Properties
        private static int nextId = 1;
        public int Id { get; set; }
        public Medarbejder AssignedMedarbejder { get; set; }
        public string StartTid { get; set; }
        public string SlutTid { get; set; }
        #endregion

        public Vagt() // Default Constructor
        {
            Id = nextId++;
            AssignedMedarbejder = new Medarbejder("", "", 0);
        }

        public Vagt(string medarbejderName, string medarbejderEmail, int medarbejderTlf, string startTid, string slutTid)
        {
            Id = nextId++;
            AssignedMedarbejder = new Medarbejder(medarbejderName, medarbejderEmail, medarbejderTlf);
            StartTid = startTid;
            SlutTid = slutTid;
        }
        public class Medarbejder
        {
            private static int nextId = 1;
            public int Id { get; set; }
            public string MedarbejderName { get; set; }
            public string MedarbejderEmail { get; set; }
            public int MedarbejderTlf { get; set; }
            public Medarbejder(string medarbejderName, string medarbejderEmail, int medarbejderTlf)
            {
                Id = nextId++;
                MedarbejderName = medarbejderName;
                MedarbejderEmail = medarbejderEmail;
                MedarbejderTlf = medarbejderTlf;
            }
        }
    }
} 


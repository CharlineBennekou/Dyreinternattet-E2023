namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
        static int nextId = 1;
        public int Id { get; }
        public Medarbejder AssignedMedarbejder { get; set; }
        public string StartTid { get; set; }
        public string SlutTid { get; set; }

        public Vagt()
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
        public static IEnumerable<Medarbejder> MedarbejderOptions()
        {
            return new List<Medarbejder>
            {
                new Medarbejder("Hans Christian Andersen", "hans@example.com", 12345678),
                new Medarbejder("Joakim Von And", "joakim@example.com", 87654321),
                new Medarbejder("Erik", "erik@example.com", 55555555),
                new Medarbejder("Odin", "odin@example.com", 98765432),
                new Medarbejder("Irene", "irene@example.com", 45678901),
                new Medarbejder("Astrid", "astrid@example.com", 11112222),
                new Medarbejder("Anni", "anni@example.com", 99998888),
                new Medarbejder("Jørgen", "jorgen@example.com", 44443333),
                new Medarbejder("Ib", "ib@example.com", 77776666),
                new Medarbejder("Åbæk", "aabek@example.com", 22221111)
            };
        }





        public static IEnumerable<string> StartTidOptions()
        {
            return new[]
            {
                "08:00", "09:00", "10:00", "11:00", "12:00",
                "13:00", "14:00", "15:00", "16:00", "17:00"
            };
        }

        public static IEnumerable<string> SlutTidOptions()
        {
            return new[]
            {
                "12:00", "13:00", "14:00", "15:00", "16:00",
                "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"
            };
        }
        public class Medarbejder
        {
            static int nextId = 1;
            public string MedarbejderName { get; set; }
            public string MedarbejderEmail { get; set; }
            public int MedarbejderTlf { get; set; }
            public Medarbejder(string medarbejderName, string medarbejderEmail, int medarbejderTlf)
            {
                MedarbejderName = medarbejderName;
                MedarbejderEmail = medarbejderEmail;
                MedarbejderTlf = medarbejderTlf;
            }
        }
    }
} 


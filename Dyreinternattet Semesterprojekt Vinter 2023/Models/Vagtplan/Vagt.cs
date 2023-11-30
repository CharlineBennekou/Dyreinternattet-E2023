using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
        static int nextId = 1;
        public int ID { get; }
        public Medarbejder Medarbejder { get; set; }
		public string StartTid { get; set; }
		public string SlutTid { get; set; }

		public Vagt()
		{
			ID= nextId++;
		}

		public Vagt(Medarbejder medarbejder, string startTid, string slutTid)
		{
			ID=nextId++;
			Medarbejder = medarbejder;
			StartTid = startTid;
			SlutTid = slutTid;
		}
        //public static IEnumerable<Vagt> MedarbejderOptions()
        //{
        //    return new[]
        //    {
        //        new Vagt { Medarbejder = new Medarbejder("John Doe", "john@example.com", 12345678) },
        //        new Vagt { Medarbejder = new Medarbejder("Jane Doe", "jane@example.com", 87654321) },
        //        new Vagt { Medarbejder = new Medarbejder("Bob Smith", "bob@example.com", 55555555) },
        //        new Vagt { Medarbejder = new Medarbejder("Sofus Jensen", "sofus@example.com", 98765432) },
        //        new Vagt { Medarbejder = new Medarbejder("Erik Andersen", "erik@example.com", 45678901) },
        //        new Vagt { Medarbejder = new Medarbejder("Sofie Nielsen", "sofie@example.com", 11112222) },
        //        new Vagt { Medarbejder = new Medarbejder("Chris Hansen", "chris@example.com", 99998888) }
        //    };
        //}
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
        //public override string ToString()
        //{
        //	return $"{Medarbejder.Name} - {StartTid.ToString("hh:mm")} to {SlutTid.ToString("hh:mm")}";
        //}

    }
} 


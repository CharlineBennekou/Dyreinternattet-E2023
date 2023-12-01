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


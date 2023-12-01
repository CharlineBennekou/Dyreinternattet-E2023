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
		//public override string ToString()
		//{
		//	return $"{Medarbejder.Name} - {StartTid.ToString("hh:mm")} to {SlutTid.ToString("hh:mm")}";
		//}

	}
} 


using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
		public Medarbejder Worker { get; set; }
		public int StartTid { get; set; }
		public int SlutTid { get; set; }

		public Vagt()
		{
		}

		public Vagt(Medarbejder worker, int starttid, int sluttid)
		{
			Worker = worker;
			StartTid = starttid;
			SlutTid = sluttid;
		}
	}
} 
}

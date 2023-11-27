using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
		public Medarbejder Worker { get; set; }
		public double StartTid { get; set; }
		public double SlutTid { get; set; }

		public Vagt()
		{
		}

		public Vagt(Medarbejder worker, double starttid, double sluttid)
		{
			Worker = worker;
			StartTid = starttid;
			SlutTid = sluttid;
		}
	}
} 


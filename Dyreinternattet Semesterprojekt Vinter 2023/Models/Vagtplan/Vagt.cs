using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan
{
    public class Vagt
    {
		public Medarbejder Medarbejder { get; set; }
		public double StartTid { get; set; }
		public double SlutTid { get; set; }

		public Vagt()
		{
		}

		public Vagt(Medarbejder medarbejder, double starttid, double sluttid)
		{
			Medarbejder = medarbejder;
			StartTid = starttid;
			SlutTid = sluttid;
		}
	}
} 


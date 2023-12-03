using System.Collections.Generic;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
	public class MockVagter
	{
		private static List<Vagt> _vagter = new List<Vagt>()
		{
			new Vagt(medarbejderName : "Joakim Von Luxemborg", medarbejderEmail : "joakim@example.com", medarbejderTlf : 12345678, startTid : "08:00", slutTid : "15:00"),
			new Vagt(medarbejderName : "Bill Smith", medarbejderEmail : "bill@example.com", medarbejderTlf : 87654321, startTid : "07:00", slutTid : "14:00"),
			new Vagt(medarbejderName: "Åge Knudsen", medarbejderEmail: "åge@example.com", medarbejderTlf: 55555555, startTid : "11:00", slutTid : "19:00")
		};

		public static List<Vagt> GetMockVagter() { return _vagter; }
	}
}

using System.Collections.Generic;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
	public class MockVagter
	{
		private static List<Vagt> _vagter = new List<Vagt>()
		{
			new Vagt(new Medarbejder("John Doe", "john@example.com", 12345678), starttid: 8.00, sluttid: 15.00),
			new Vagt(new Medarbejder("Jane Doe", "jane@example.com", 87654321), starttid: 7.30, sluttid: 14.30),
			new Vagt(new Medarbejder("Bob Smith", "bob@example.com", 55555555), starttid: 15.00, sluttid: 23.00)
		};

		public static IEnumerable<Vagt>? MedarbejderOptions()
		{
			return new[]
			{
				new Vagt { Medarbejder = new Medarbejder("John Doe", "john@example.com", 12345678) },
				new Vagt { Medarbejder = new Medarbejder("Jane Doe", "jane@example.com", 87654321) },
				new Vagt { Medarbejder = new Medarbejder("Bob Smith", "bob@example.com", 55555555) }
			};
		
		}
		public static List<Vagt> GetMockVagter() { return _vagter; }
	}
}

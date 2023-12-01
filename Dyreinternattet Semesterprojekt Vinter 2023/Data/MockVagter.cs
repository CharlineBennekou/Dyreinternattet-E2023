﻿using System.Collections.Generic;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
	public class MockVagter
	{
		private static List<Vagt> _vagter = new List<Vagt>()
		{
			new Vagt(new Medarbejder("John Doe", "john@example.com", 12345678), startTid: "8:00", slutTid: "15:00"),
			new Vagt(new Medarbejder("Jane Doe", "jane@example.com", 87654321), startTid : "8:00", slutTid : "15:00"),
			new Vagt(new Medarbejder("Bob Smith", "bob@example.com", 55555555), startTid : "8:00", slutTid : "15:00")
		};

		public static IEnumerable<Vagt>? MedarbejderOptions()
		{
			return new[]
			{
				new Vagt { Medarbejder = new Medarbejder("John Doe", "john@example.com", 12345678) },
				new Vagt { Medarbejder = new Medarbejder("Jane Doe", "jane@example.com", 87654321) },
				new Vagt { Medarbejder = new Medarbejder("Bob Smith", "bob@example.com", 55555555) },
				new Vagt { Medarbejder = new Medarbejder("Sofus Jensen", "sofus@example.com", 98765432) },
				new Vagt { Medarbejder = new Medarbejder("Erik Andersen", "erik@example.com", 45678901) },
				new Vagt { Medarbejder = new Medarbejder("Sofie Nielsen", "sofie@example.com", 11112222) },
				new Vagt { Medarbejder = new Medarbejder("Chris Hansen", "chris@example.com", 99998888) }
			};
		}

		public static List<Vagt> GetMockVagter() { return _vagter; }
	}
}

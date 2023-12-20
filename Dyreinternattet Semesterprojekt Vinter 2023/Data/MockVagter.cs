using System.Collections.Generic;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;
using static Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan.Vagt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Data
{
	public class MockVagter
	{
		private static List<Vagt> _vagter = new List<Vagt>()
		{
			new Vagt(medarbejderName : "Joakim Von Luxemborg", 
                medarbejderEmail : "joakim@example.com", 
                medarbejderTlf : 12345678, startTid : "08:00", slutTid : "15:00"),
			new Vagt(medarbejderName : "Bill Smith", 
                medarbejderEmail : "bill@example.com", 
                medarbejderTlf : 87654321, startTid : "07:00", slutTid : "14:00"),
			new Vagt(medarbejderName: "Åge Knudsen", 
                medarbejderEmail: "åge@example.com", 
                medarbejderTlf: 55555555, startTid : "11:00", slutTid : "19:00")
		};
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
        public static List<Vagt> GetMockVagter() { return _vagter; }
	}
}

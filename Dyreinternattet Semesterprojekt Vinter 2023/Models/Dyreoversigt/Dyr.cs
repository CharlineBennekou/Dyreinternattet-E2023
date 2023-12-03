using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Dyr
    {
        public enum DyreArt //Enum med dyrearter
        {
			Hund=1,
            Kat=2,
            Kanin=3,  
        }




        //Id'et bliver aktomatisk givet og alle Id bliver unikke
        static int nextId = 1;
        public int ID { get; }
        [EnumDataType(typeof(DyreArt))]
        public DyreArt Art { get; set; }
        public string Navn { get; set; }
        public string Race { get; set; }
        public double Alder { get; set; }
        public double Vægt { get; set; }
        public bool VaccineStatus { get; set; }
        public bool ErAdopteret { get; set; }
        public string ImagePath { get; set; }
        public string Beskrivelse { get; set; }


        //Den defaulte constructor skal have et Id ligemeget hvad
        public Dyr()
        {
            ID = nextId++;
            ImagePath = "/images/image1.png";
        }


        public Dyr(DyreArt art, string navn, string race, double alder, double vægt, bool vaccineStatus, bool erAdopteret, string imagepath, string beskrivelse)
        {
            
            Art = art;
            ID = nextId++;
            Navn = navn;
            Race = race;
            Alder = alder;
            Vægt = vægt;
            VaccineStatus = vaccineStatus;
            ErAdopteret = erAdopteret;
            ImagePath = imagepath;
            Beskrivelse = beskrivelse;
            
            
        }

     

    }


}

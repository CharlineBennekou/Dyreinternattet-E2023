using DocumentFormat.OpenXml.Spreadsheet;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Dyr
    {
        public enum DyreArt //Enum med dyrearter
        {
			Hund=0,
            Kat=1,
            Kanin=2,  
        }
        public enum EKøn
        { 
        Han=0,
        Hun=1,
        }




        //Id'et bliver aktomatisk givet og alle Id bliver unikke
       static int nextId = 1;
        public int ID { get; set; }
        public DyreArt Art { get; set; }
        public EKøn Køn { get; set; }
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
            switch (Art)
            {
                case DyreArt.Hund:
                    ImagePath = "/images/dog1.jpg";
                    break;
                case DyreArt.Kat:
                    ImagePath = "/images/kat1.jpg";
                    break;
                case DyreArt.Kanin:
                    ImagePath = "/images/kanin1.jpg";
                    break;
                default:
                    ImagePath = null;
                    break;
            }





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

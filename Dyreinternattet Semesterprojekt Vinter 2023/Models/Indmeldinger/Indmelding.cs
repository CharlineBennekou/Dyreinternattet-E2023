using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger

{
    public class Indmelding
    {


        public enum DyrType
        {
            Hund = 0,
            Kat = 1,
            Kanin = 2,
        }
        public enum DyrKøn
        {
            Han = 0,
            Hun = 1,
        }


        static int nextId = 1;
        public int ID { get; set; }
        public DyrType DyrArt { get; set; }
        public string DyrName { get; set; }
        public DyrKøn DyrGender { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsVac { get; set; }
        public string DyrInfo { get; set; }


        public string EjerName { get; set; }
        public string EjerAddress { get; set; }
        public int EjerPost { get; set; }
        public string EjerTlf { get; set; }
        public string EjerMail { get; set; }



        public Indmelding()
        {
            ID = nextId++;
        }


        public Indmelding(DyrType dyrArt, string dyrName, DyrKøn dyrGender, string race, int age, double weight, bool isVac,
            string dyrInfo, string ejerName, string ejerAddress, int ejerPost, string ejerTlf, string ejerMail)
        {
            ID = nextId++;
            DyrArt = dyrArt;        
            DyrName = dyrName;
            DyrGender = dyrGender;
            Race = race;
            Age = age;
            Weight = weight;
            IsVac = isVac;
            DyrInfo = dyrInfo;
            EjerName = ejerName;
            EjerAddress = ejerAddress;
            EjerPost = ejerPost;
            EjerTlf = ejerTlf;
            EjerMail = ejerMail;
        }

    }
}

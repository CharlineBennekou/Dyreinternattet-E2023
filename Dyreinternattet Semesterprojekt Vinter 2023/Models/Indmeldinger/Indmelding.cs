namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger
{
    public class Indmelding
    {

        static int nextId = 1;
        public int ID { get; set; }
        public string DyrType { get; set; }
        public string DyrName { get; set; }
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


        public Indmelding(string dyrType, string dyrName, string race, int age, double weight, bool isVac,
            string dyrInfo, string ejerName, string ejerAddress, int ejerPost, string ejerTlf, string ejerMail)
        {
            ID = nextId++;
            DyrType = dyrType;
            DyrName = dyrName;
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

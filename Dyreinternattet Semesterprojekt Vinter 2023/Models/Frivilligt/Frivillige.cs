namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt
{
    public class Frivillige
    {
        static int nextId = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public int Postnummer { get; set; }
        public string Tlf { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }

        public Frivillige()
        {
            ID = nextId++;
        }

        public Frivillige(string name, string birthday, string address, int postnummer, string tlf, string mail, string description)
        {
            ID = nextId++;
            Name = name;
            Birthday = birthday;
            Address = address;
            Postnummer = postnummer;
            Tlf = tlf;
            Mail = mail;
            Description = description;
        }
    }

}


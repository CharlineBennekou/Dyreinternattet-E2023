namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt
{
    public class Frivillige
    {

        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Tlf { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }

        public Frivillige()
        {
        }

        public Frivillige(string name, string birthday, string address, string tlf, string mail, string description)
        {
            Name = name;
            Birthday = birthday;
            Address = address;
            Tlf = tlf;
            Mail = mail;
            Description = description;
        }
    }

}


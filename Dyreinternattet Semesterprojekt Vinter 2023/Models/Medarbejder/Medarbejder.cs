namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt
{
    public class Medarbejder
    {
        static int nextId = 1;
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public int Tlf { get; set; }

        public enum Medarbejdere
        {
            Andersine,
            Kathrine,
            Ole,
            Jeanette,
            Jørgen,
            Jakob
        }

        public Medarbejder()
        {
            Id = nextId++;
        }

        public Medarbejder(string name, string email, int tlf)
        {
            Id = nextId++;
            Name = name;
            Email = email;
            Tlf = tlf;
        }

		public override string ToString()
		{
            return Name;
		}
	}
}

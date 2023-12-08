using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Kalender;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class BesøgService : IBesøgService
    {
        private List<Besøg> _besøgsListe;

        public List<Besøg> GetBesøg()
        {
            return _besøgsListe;
        }

        public void AddBesøg(Besøg besøg)
        {
            _besøgsListe.Add(besøg);
        }

        public void UpdateBesøg(Besøg besøg)
        {
            if (besøg != null)
            {
                foreach (Besøg b in _besøgsListe)
                {
                    if (b.Id == besøg.Id)
                    {
                        b.StartTid = besøg.StartTid;
                        b.SlutTid = besøg.SlutTid;
                        b.Note = besøg.Note;
                    }
                }
            }
        }

        public Besøg DeleteCustomer(int? id)
        {
            foreach (Besøg besøg in _besøgsListe)
            {
                if (besøg.Id == id)

                    _besøgsListe.Remove(besøg);
                return besøg;
            }
            return null;

            List<Besøg> IBesøgService.GetBesøg()
        {
                throw new NotImplementedException();
            }

            public void AddBesøg(Besøg besøg)
            {
                throw new NotImplementedException();
            }

            public void UpdateBesøg(Besøg besøg)
            {
                throw new NotImplementedException();
            }

            public Besøg DeleteBesøg(int? id)
            {
                throw new NotImplementedException();
            }
        }

        public Besøg DeleteBesøg(int? id)
        {
            throw new NotImplementedException();
        }
    }


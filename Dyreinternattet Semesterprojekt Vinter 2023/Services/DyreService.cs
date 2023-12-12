using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Data;
using System.Diagnostics.Eventing.Reader;
using static Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt.Dyr;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class _dyreService : IDyreService //Bruger interface
    {
        private JsonFileDyrService JsonFileDyrService { get; set; } //Auto property for Jsonfilservice

        private List<Dyr> _dyreliste; //Instance field kan referere til en liste af dyr

        public _dyreService(JsonFileDyrService jsonFileDyrService) //Når DyreService constructes, henter dyrelisten data fra jsonfil
        {
            JsonFileDyrService = jsonFileDyrService;
            //_dyreliste = MockDyr.GetMockDyr();
            _dyreliste = JsonFileDyrService.GetJsonDyr().ToList();
        }
        public _dyreService() //Backup hvis json ikk virker
        {
            _dyreliste = MockDyr.GetMockDyr();
        }
        
        public void AddDyr(Dyr dyr) 
        {
            _dyreliste.Add(dyr);
            JsonFileDyrService.SaveJsonDyr(_dyreliste);
        }

        public void UpdateDyr(Dyr dyr) 
        {
        if (dyr != null) //Opdaterer kun hvis input ikke er null
            {
                foreach (Dyr d in _dyreliste) //Tjekker alle dyr
                {
                    if (d.ID ==  dyr.ID) //Hvis ID matcher, opdateres info
                    {
                        Console.WriteLine(dyr);
                        Console.WriteLine("fundet");
                        d.Køn = dyr.Køn;
                        d.Art = dyr.Art;
                        d.Navn = dyr.Navn;
                        d.Race = dyr.Race;
                        d.Alder = dyr.Alder;
                        d.Vægt = dyr.Vægt;
                        d.VaccineStatus = dyr.VaccineStatus;
                        d.ErAdopteret = dyr.ErAdopteret;
                        d.ImagePath = dyr.ImagePath;
                        d.Beskrivelse = dyr.Beskrivelse;

                        

                    }
                    
                }
                JsonFileDyrService.SaveJsonDyr(_dyreliste); //Listen gemmes i json bagefter
            }
            Console.WriteLine("dyr er null");
        }
       

        public Dyr DeleteDyr(int? id)
        {
            Dyr DyrToBeDeleted = null; //Sætter midlertidig variabel til at være null, så den returnerer null hvis dyret ik findes og derfor ikke slettes
            foreach (Dyr dyr in _dyreliste)  //Tjekker alle dyr
            {
                if (dyr.ID == id) //Hvis ID matcher, vil vores midlertidige reference referere til dette dyr
                {
                    DyrToBeDeleted = dyr;
                    break;

                }
            }
            if (DyrToBeDeleted != null) //Hvis midlertidig reference refererer til et dyr, vil dyret blive slettet og listen opdateret
            {
                _dyreliste.Remove(DyrToBeDeleted);
                JsonFileDyrService.SaveJsonDyr(_dyreliste);

            }
            return DyrToBeDeleted;

        }

        public Dyr GetDyrID(int id)
        {
            foreach (Dyr dyr in _dyreliste)
            {
                if (dyr.ID == id)
                { return dyr; }
            }
            return null;
        }



        public List<Dyr> GetDyr() //metode til at returnere dyrelisten
        {
            return _dyreliste;
        }


        public IEnumerable<Dyr> Search(string searchTerm)
        {
            List<Dyr> searchResults = new List<Dyr>();

            foreach (Dyr d in _dyreliste)
            {
                if (string.IsNullOrEmpty(searchTerm) ||
                    d.Navn.ToLower().Contains(searchTerm.ToLower()) ||
                    d.Race.ToLower().Contains(searchTerm.ToLower()))

                {
                    searchResults.Add(d);
                }   
            }

            return searchResults;
        }







        //public IEnumerable<Dyr> NameSearch(string str) //metode til søgefunktion med navn
        //{
        //    List<Dyr> nameSearch = new List<Dyr>();
        //    foreach (Dyr d in _dyreliste)
        //    {
        //        if ((string.IsNullOrEmpty(str)) || (d.Navn.ToLower().Contains(str.ToLower())))
        //                {
        //                    nameSearch.Add(d);
        //                }

        //    }
        //    return nameSearch;
        //}



        public IEnumerable<Dyr> DyreFilter(Dyr.DyreArt Art, Dyr.EKøn Køn)
        {
            List<Dyr> filterList = new List<Dyr>();
            foreach (Dyr dyr in _dyreliste)
            {
                if (dyr.Art == Art && dyr.Køn == Køn)
                {
                    filterList.Add(dyr);
                }

            }
            return filterList;




        }

        public IEnumerable<Dyr> DyrFilter(Dyr.DyreArt Art, Dyr.EKøn Køn)
        {
            throw new NotImplementedException();
        }
    }
}

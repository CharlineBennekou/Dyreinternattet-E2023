using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IDyreService //interface som bruges af dyreservice
    {
        List<Dyr> GetDyr();
        Dyr GetDyrID(int id);
        void AddDyr(Dyr dyr);
        void UpdateDyr(Dyr dyr);
        Dyr DeleteDyr(int? id);
        IEnumerable<Dyr> NameSearch(string str);

        //    IEnumerable<Dyr> DyrFilter(string Race, Dyr.DyreArt Art, Dyr.EKøn Køn);
        //}

    }
   
}

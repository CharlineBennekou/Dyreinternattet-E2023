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
        void UpdateDyrImage(Dyr dyr);
        Dyr DeleteDyr(int? id);

        // Dene metode retunere en IEnumerable af Dyr-objekter baseret på et søgeterme.
        // Paratret "searchTerm" er strenges der bruges til at søge efter Dyr-objekter.
        // Returnerer en samling af Dyr, der matcher søgetermen.
        IEnumerable<Dyr> Search(string searchTerm);
    }

}
   


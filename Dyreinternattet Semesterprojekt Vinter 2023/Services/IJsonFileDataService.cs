using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using System.Text.Json;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IJsonFileDataService<T> //På ingen måde færdig. Held og lykke :)
    {
        //public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
        ////public JsonFileTService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
        ////{
        ////    WebHostEnvironment = webHostEnvironment;
        ////}

        //private string JsonFileName
        //{
        //    get
        //    {
        //        return Path.Combine(WebHostEnvironment.WebRootPath,
        //    "Data");
        //    }
        //}

        //public void SaveJsonOject(List<T> dyr)
        //{
        //    using (FileStream jsonFileWriter = File.Create(JsonFileName))
        //    {
        //        Utf8JsonWriter jsonWriter = new Utf8JsonWriter(
        //        jsonFileWriter, new JsonWriterOptions()
        //        {
        //            SkipValidation = false,
        //            Indented = true
        //        });
        //        JsonSerializer.Serialize<Dyr[]>(jsonWriter, Dyreliste.ToArray()); //Mangler dyreliste for at implementere
        //    }

        //    public IEnumerable<Dyr> GetJsonItems()
        //    {
        //        using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
        //        {
        //            return JsonSerializer.Deserialize<Dyr[]>(jsonFileReader.ReadToEnd());
        //        }
        //    }

        //}
    }
}

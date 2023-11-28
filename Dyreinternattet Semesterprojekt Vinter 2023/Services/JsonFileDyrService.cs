using System.Text.Json;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class JsonFileDyrService
    {

        public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
        public JsonFileDyrService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,
            "Data", "Dyr.json");
            }
        }

        public void SaveJsonDyr(List<Dyr> dyr) //Liste som input
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName)) //Fil skabes eller bruges
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter( //JsonWriter skabes
                jsonFileWriter, new JsonWriterOptions() //Indstillinger
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Dyr[]>(jsonWriter, dyr.ToArray()); //Seriliseres
            }

        }

        public IEnumerable<Dyr> GetJsonDyr() //burde være public, virker ik?
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Dyr[]>(jsonFileReader.ReadToEnd());
            }
        }


    }
}

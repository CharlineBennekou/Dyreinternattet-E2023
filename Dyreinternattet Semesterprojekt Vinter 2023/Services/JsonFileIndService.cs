using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Indmeldinger;
using System.Text.Json;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class JsonFileIndService
    {

        public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
        public JsonFileIndService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Indmelding.json");
            }
        }

        public void SaveJsonInd(List<Indmelding> indmelding) //Liste som input
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName)) //Fil skabes eller bruges
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter( //JsonWriter skabes
                jsonFileWriter, new JsonWriterOptions() //Indstillinger
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Indmelding[]>(jsonWriter, indmelding.ToArray()); //Seriliseres
            }

        }

        public IEnumerable<Indmelding> GetJsonInd() //burde være public, virker ik?
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Indmelding[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}

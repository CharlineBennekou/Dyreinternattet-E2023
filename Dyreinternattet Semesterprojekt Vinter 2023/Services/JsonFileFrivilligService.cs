using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;
using System.Text.Json;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class JsonFileFrivilligService
    {


        public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
        public JsonFileFrivilligService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Frivillig.json");
            }
        }

        public void SaveJsonFrivillig(List<Frivillige> frivillige) //Liste som input
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName)) //Fil skabes eller bruges
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter( //JsonWriter skabes
                jsonFileWriter, new JsonWriterOptions() //Indstillinger
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Frivillige[]>(jsonWriter, frivillige.ToArray()); //Seriliseres
            }

        }

        public IEnumerable<Frivillige> GetJsonFrivillig() //burde være public, virker ik?
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Frivillige[]>(jsonFileReader.ReadToEnd());
            }
        }

    }
}

using System.Text.Json;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
	public class JsonFileVagtService
	{

		public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
		public JsonFileVagtService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
		{
			WebHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName
		{
			get
			{
				return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Vagt.json");
			}
		}

		public void SaveJsonVagter(List<Vagt> vagt) //Liste som input
		{
			using (FileStream jsonFileWriter = File.Create(JsonFileName)) //Fil skabes eller bruges
			{
				Utf8JsonWriter jsonWriter = new Utf8JsonWriter( //JsonWriter skabes
				jsonFileWriter, new JsonWriterOptions() //Indstillinger
				{
					SkipValidation = false,
					Indented = true
				});
				JsonSerializer.Serialize<Vagt[]>(jsonWriter, vagt.ToArray()); //Seriliseres
			}

		}

		public IEnumerable<Vagt> GetJsonVagter() //burde være public, virker ik?
		{
			using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<Vagt[]>(jsonFileReader.ReadToEnd());
			}
		}


	}
}

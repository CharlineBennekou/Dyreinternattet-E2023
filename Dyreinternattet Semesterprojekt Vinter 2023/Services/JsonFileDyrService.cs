﻿using System.Text.Json;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class JsonFileDyrService
    {

        //public IWebHostEnvironment WebHostEnvironment { get; } //En service som får placering af json filen. Skal initialiseres.
        //public JsonFileDyrService(IWebHostEnvironment webHostEnvironment) //Initialiseres med dependency injection
        //{
        //    WebHostEnvironment = webHostEnvironment;
        //}

        //private string JsonFileName
        //{
        //    get
        //    {
        //        return Path.Combine(WebHostEnvironment.WebRootPath,
        //    "Data", "Dyr.json");
        //    }
        //}

        //public void SaveJsonDyr(List<Dyr> dyr)
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

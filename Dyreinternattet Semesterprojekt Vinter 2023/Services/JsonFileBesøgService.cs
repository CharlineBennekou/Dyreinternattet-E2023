namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public class JsonFileBesøgService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileBesøgService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,
            "Data", "Besøg.json");
            }
        }

    }


}

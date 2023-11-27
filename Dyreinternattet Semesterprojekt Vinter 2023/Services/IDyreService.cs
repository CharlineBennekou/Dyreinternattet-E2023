﻿using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Dyreoversigt;
using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Vagtplan;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IDyreService //interface som bruges af dyreservice
    {
        List<Dyr> GetDyr();
    }
}

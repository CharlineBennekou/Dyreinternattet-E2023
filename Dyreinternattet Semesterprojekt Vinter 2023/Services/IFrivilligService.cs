﻿using Dyreinternattet_Semesterprojekt_Vinter_2023.Models.Frivilligt;

namespace Dyreinternattet_Semesterprojekt_Vinter_2023.Services
{
    public interface IFrivilligService
    {

        List<Frivillige> GetFrivillig();

        void AddFrivillig(Frivillige frivillige);

    }
}

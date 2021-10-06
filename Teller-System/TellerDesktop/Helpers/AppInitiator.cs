using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public static class AppInitiator
    {
        public static void InitiateApp()
        {
            DataProvider.UpdateBranchesFromDataBase();
            DataProvider.UpdateCurrenciesfromDataBase();
        }
    }
}

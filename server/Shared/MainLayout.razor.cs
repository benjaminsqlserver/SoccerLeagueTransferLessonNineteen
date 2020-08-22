using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace SoccerLeagueTransferApp.Layouts
{
    public partial class MainLayoutComponent
    {

        public int CurrentYear()
        {
            return DateTime.Now.Year;
        }


        public String CurrentYearToString()
        {
            return CurrentYear().ToString();
        }

        private async Task CopyRightString()
        {
            copyMsg = "SoccerTransferApp, Copyright Ⓒ " + CurrentYearToString() + " Muyik Software And Music Company.";

            
        }

    }
}

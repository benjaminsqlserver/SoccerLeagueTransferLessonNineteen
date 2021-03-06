﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;
using SoccerLeagueTransferApp.Data;
using Microsoft.AspNetCore.Components.Authorization;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class EditClubDetailComponent
    {

        //implement access control for this page

        [Inject]

        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        public async Task CheckUserStatus()//it checks if anonymous user has signed in
        {
            try
            {
                var userState = await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();

                if (userState.User.Claims.Any() && userState.User.IsInRole("SiteAdmin"))// check if user has any claims and see if user belongs to site admin role
                {
                    var conDataGetClubDetailByTeamIdResult = await ConData.GetClubDetailByTeamId(TeamID);
                    clubdetail = conDataGetClubDetailByTeamIdResult;

                }
                else
                {
                    //redirect user back to club detail list page

                    UriHelper.NavigateTo("club-detail", true);
                }
                
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Application Error", "An Error Has Occurred.Please Contact Site Admin", 5000);
            }

        }

    }
}

﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SoccerLeagueTransferApp.Data;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class ConfirmDeleteRoleComponent
    {

        //custom method to delete a role

        private async Task MuyikDeleteRole()
        {
            try
            {
                //delete role record by passing in the roleID of the selected record to the delete method as parameter
                await ConData.DeleteRole(RoleID);

                //redirect to roles list page
                UriHelper.NavigateTo("roles", true);
            }
            catch (Exception)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Role Delete Error", "An Error Occurred While You Were Deleting Role.Please Contact System Admin", 5000);
            }
        }


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
                    var conDataGetRoleByRoleIdResult = await ConData.GetRoleByRoleId(RoleID);
                    role = conDataGetRoleByRoleIdResult;

                }
                else
                {
                    UriHelper.NavigateTo("roles", true);//redirect to login page
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "Application Error", "An Error Has Occurred.Please Contact Site Admin", 5000);
            }

        }

    }
}

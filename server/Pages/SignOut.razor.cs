using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.SessionStorage;
using SoccerLeagueTransferApp.Data;

namespace SoccerLeagueTransferApp.Pages
{
    public partial class SignOutComponent
    {

        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }

       

        //asynchronous method to logout user
        private async Task LogOut()
        {
            try
            {
                var userState = await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();//get user authentication state
                if (userState.User.Identity.IsAuthenticated)
                {
                   
                    ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut(userState.User.Identity.Name);//log out user
                    UriHelper.NavigateTo("login");
                }
                else
                {
                    UriHelper.NavigateTo("login");
                }
            }
            catch (Exception ex)
            {
                NotificationService.Notify(NotificationSeverity.Error, "User Error", "You Have Already Signed Out.Navigate To Login Page To Sign In", 5000);
            }

        }

    }
}

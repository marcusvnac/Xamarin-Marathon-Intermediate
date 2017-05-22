using System;
using Lab04.Authentication;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Lab04.iOS.Authentication;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateiOS))]
namespace Lab04.iOS.Authentication
{
    public class AuthenticateiOS : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(UIKit.UIApplication.SharedApplication.KeyWindow.RootViewController, provider);
            }
            catch
            {
                return null;
            }
        }
    }
}
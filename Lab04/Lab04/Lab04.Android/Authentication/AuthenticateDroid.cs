using System;
using System.Threading.Tasks;
using Lab04.Authentication;
using Lab04.Droid.Authentication;
using Microsoft.WindowsAzure.MobileServices;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateDroid))]
namespace Lab04.Droid.Authentication
{
    public class AuthenticateDroid : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(Xamarin.Forms.Forms.Context, provider);
            }
            catch
            {
                return null;
            }
        }
    }
}
using Lab04.Authentication;
using Lab04.UWP.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

[assembly: Xamarin.Forms.Dependency(typeof(AuthenticateUWP))]
namespace Lab04.UWP.Authentication
{
    public class AuthenticateUWP : IAuthenticate
    {
        public async Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider)
        {
            try
            {
                return await client.LoginAsync(provider);
            }
            catch
            {
                return null;
            }
        }
    }
}

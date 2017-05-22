using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Lab04.Authentication
{
    public interface IAuthenticate
    {
        Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider);
    }
}

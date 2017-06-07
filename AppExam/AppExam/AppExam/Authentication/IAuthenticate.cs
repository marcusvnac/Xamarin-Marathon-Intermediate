using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace AppExam.Authentication
{
    public interface IAuthenticate
    {
        Task<MobileServiceUser> Authenticate(MobileServiceClient client, MobileServiceAuthenticationProvider provider);
    }
}

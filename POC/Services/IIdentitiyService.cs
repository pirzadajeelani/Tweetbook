using System.Threading.Tasks;
using POC.Domain;

namespace POC.Services
{
    public interface IIdentitiyService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}

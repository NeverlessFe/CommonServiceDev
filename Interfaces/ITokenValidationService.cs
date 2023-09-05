using CommonServiceCore.Interfaces;
using CommonServiceCore.Models;

namespace CommonServiceCore.Interfaces
{
    public interface ITokenValidationService
    {
        Task<List<TblTTokenValidation>> GetTokenValidationServices(TokenAttributes value);

        Task<List<TokenValue>> GenerateToken(TokenAttributes value);
    }
}

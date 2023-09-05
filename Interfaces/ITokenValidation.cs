using CommonServiceCore.Models;
using CommonServiceCore.Repository;

namespace CommonServiceCore.Interfaces
{
    public interface ITokenValidation
    {
        Task<List<TblTTokenValidation>> GetTokenValidationRepo(TokenAttributes value);
        Task<List<TokenValue>> GenerateToken(TokenAttributes value);
    }
}

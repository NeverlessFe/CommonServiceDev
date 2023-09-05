using CommonServiceCore.Models;
using CommonServiceCore.Interfaces;

namespace CommonServiceCore.Services
{
    public class TokenValidationServices : ITokenValidationService
    {
        public readonly ITokenValidation _tokenValidation;

        public TokenValidationServices(ITokenValidation tokenValidation)
        {
            _tokenValidation = tokenValidation;
        }

        public Task<List<TblTTokenValidation>> GetTokenValidationServices(TokenAttributes value)
        {
            return _tokenValidation.GetTokenValidationRepo(value);
        }

        public Task<List<TokenValue>> GenerateToken(TokenAttributes value)
        {
            return _tokenValidation.GenerateToken(value);
        }
    }
}

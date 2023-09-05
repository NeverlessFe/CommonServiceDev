using CommonServiceCore.Models;
using CommonServiceCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CommonServiceCore.Repository
{
    public class TokenValidation : ITokenValidation
    {
        public readonly MasterApprovalContext _MasterApprovalContext;

        public TokenValidation(MasterApprovalContext Context)
        {
            _MasterApprovalContext = Context;
        }

        public async Task<List<TblTTokenValidation>> GetTokenValidationRepo(TokenAttributes value)
        {
            try
            {
                var query = (from TblTTokenValidation in _MasterApprovalContext.TblTTokenValidations
                             select new TblTTokenValidation
                             {
                                 UserAd = TblTTokenValidation.UserAd,
                                 Idapps = TblTTokenValidation.Idapps,
                                 Token = TblTTokenValidation.Token,
                                 IsActive = TblTTokenValidation.IsActive,
                                 ValidUntil = TblTTokenValidation.ValidUntil
                             });
                return await query.AsNoTracking().ToListAsync();
            }catch(Exception ex)
            {
                throw;
            }
        }

        public async Task<List<TokenValue>> GenerateToken(TokenAttributes value)
        {
            try
            {
                string ToReturn = "";
                Guid obj = Guid.NewGuid();

                TblTTokenValidation tval = new TblTTokenValidation()
                {
                    UserAd = value.UserAD,
                    Idapps = value.IDApps,
                    Token = obj.ToString(),
                    IsActive = true,
                    ValidUntil = DateTime.Now.AddDays(1)
                };


                List<TokenValue> tvalreturn = new List<TokenValue>();
                TokenValue row = new TokenValue();
                row.IdApps = value.IDApps;
                row.Username = value.UserAD;
                row.Token = obj.ToString();
                row.IsActive = true;
                row.Validation = DateTime.Now.AddDays(1);

                tvalreturn.Add(row);

                await _MasterApprovalContext.TblTTokenValidations.AddAsync(tval);

                await _MasterApprovalContext.SaveChangesAsync();

                return tvalreturn;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}

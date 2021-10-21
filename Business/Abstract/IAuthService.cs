using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using DataAccess.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}

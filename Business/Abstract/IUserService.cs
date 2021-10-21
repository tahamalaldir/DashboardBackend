using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetList();
        IDataResult<User> GetById(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

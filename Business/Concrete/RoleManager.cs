using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public IDataResult<List<Role>> GetList()
        {
            return new SuccessDataResult<List<Role>>(_roleDal.GetList().ToList());
        }

        public IDataResult<Role> GetById(int roleId)
        {
            return new SuccessDataResult<Role>(_roleDal.Get(r => r.Id == roleId));
        }

        public IResult Add(Role role)
        {
            _roleDal.Add(role);
            return new SuccessResult(Messages.RoleAdded);
        }

        public IResult Delete(Role role)
        {
            _roleDal.Delete(role);
            return new SuccessResult(Messages.RoleDeleted);
        }

        public IResult Update(Role role)
        {
            _roleDal.Update(role);
            return new SuccessResult(Messages.RoleUpdated);
        }
    }
}

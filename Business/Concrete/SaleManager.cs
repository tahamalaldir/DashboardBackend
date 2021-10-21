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
    public class SaleManager : ISaleService
    {
        private readonly ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }

        public IDataResult<List<Sale>> GetList()
        {
            return new SuccessDataResult<List<Sale>>(_saleDal.GetList().ToList());
        }

        public IDataResult<Sale> GetById(int saleId)
        {
            return new SuccessDataResult<Sale>(_saleDal.Get(s => s.Id == saleId));
        }

        public IResult Add(Sale sale)
        {
            _saleDal.Add(sale);
            return new SuccessResult(Messages.SaleAdded);
        }

        public IResult Delete(Sale sale)
        {
            _saleDal.Delete(sale);
            return new SuccessResult(Messages.SaleDeleted);
        }

        public IResult Update(Sale sale)
        {
            _saleDal.Update(sale);
            return new SuccessResult(Messages.SaleUpdated);
        }
    }
}

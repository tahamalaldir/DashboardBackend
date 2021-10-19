using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISaleService
    {
        IDataResult<List<Sale>> GetList();
        IDataResult<Sale> GetById(int saleId);
        IResult Add(Sale sale);
        IResult Delete(Sale sale);
        IResult Update(Sale sale);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditScoreService
    {
        IDataResult<List<CreditScore>> GetAll();
        IDataResult<CreditScore> GetById(int id);
        IDataResult<CreditScore> GetByUserId(int id);
        IResult Add(CreditScore score);
        IResult Update(CreditScore score);
        IResult Delete(CreditScore score);
    }
}

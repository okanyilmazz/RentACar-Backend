using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditScoreManager : ICreditScoreService
    {
        ICreditScoreDal _creditScoreDal;
        public CreditScoreManager(ICreditScoreDal creditScoreDal)
        {
            _creditScoreDal = creditScoreDal;
            
        }
        public IResult Add(CreditScore score)
        {
            _creditScoreDal.Add(score);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(CreditScore score)
        {
            _creditScoreDal.Delete(score);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<CreditScore> GetById(int id)
        {
            return new SuccessDataResult<CreditScore>(_creditScoreDal.Get(c=>c.Id==id));
        }

        public IDataResult<List<CreditScore>> GetAll()
        {
            return new SuccessDataResult<List<CreditScore>>(_creditScoreDal.GetAll());
        }

        public IDataResult<CreditScore> GetByUserId(int id)
        {
            return new SuccessDataResult<CreditScore>(_creditScoreDal.Get(c => c.UserId == id));
        }

        public IResult Update(CreditScore score)
        {
            _creditScoreDal.Update(score);
            return new Result(true, Messages.Updated);
        }
    }
}

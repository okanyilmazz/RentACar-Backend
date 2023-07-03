using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountyManager : ICountyService
    {
        ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;

        }

        public IResult Add(County county)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(County county)
        {
            throw new NotImplementedException();
        }

        public IDataResult<County> GetById(int id)
        {
            return new SuccessDataResult<County>(_countyDal.Get(b => b.Id == id));
        }

        public IDataResult<List<County>> GetAll()
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll());
        }

        public IResult Update(County county)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<County>> GetByCityId(int id)
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll(b => b.CityId == id).OrderBy(x=>x.CountyName).ToList());
        }
    }
}

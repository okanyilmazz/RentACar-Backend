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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;

        }
        public IResult Add(Country country)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Country country)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(b => b.CountryId == id));
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll().OrderBy(x=>x.CountryName).ToList());
        }

        public IResult Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}

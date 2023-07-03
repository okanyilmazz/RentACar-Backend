using Business.Abstract;
using Business.Constants;
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
    public class DriverManager : IDriverService
    {
        IDriverDal _driverDal;
        public DriverManager(IDriverDal driverDal)
        {
            _driverDal = driverDal;
        }
        public IResult Add(Driver driver)
        {
            _driverDal.Add(driver);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Driver driver)
        {
            _driverDal.Delete(driver);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<Driver>> GetAll()
        {
            return new SuccessDataResult<List<Driver>>(_driverDal.GetAll());
        }

        public IDataResult<List<Driver>> GetByCarId(int id)
        {
            return new SuccessDataResult<List<Driver>>(_driverDal.GetAll(d => d.Id == id));
        }

        public IDataResult<Driver> GetById(int id)
        {
            return new SuccessDataResult<Driver>(_driverDal.Get(d => d.Id == id));
        }

        public IResult Update(Driver driver)
        {
            _driverDal.Update(driver);
            return new Result(true, Messages.Updated);
        }
    }
}

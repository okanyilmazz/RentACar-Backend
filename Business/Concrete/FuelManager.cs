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
    public class FuelManager : IFuelService
    {
        IFuelDal _fuelDal;
        public FuelManager(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }
        public IResult Add(Fuel fuel)
        {
            _fuelDal.Add(fuel);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Fuel fuel)
        {
            _fuelDal.Delete(fuel);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<Fuel> Get(int id)
        {
            return new SuccessDataResult<Fuel>(_fuelDal.Get(f => f.Id == id));
        }

        public IDataResult<List<Fuel>> GetAll()
        {
            return new SuccessDataResult<List<Fuel>>(_fuelDal.GetAll());
        }

        public IResult Update(Fuel fuel)
        {
            _fuelDal.Update(fuel);
            return new Result(true, Messages.Updated);
        }
    }
}

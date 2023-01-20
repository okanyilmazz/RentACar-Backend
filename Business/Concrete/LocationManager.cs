using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IResult Add(Location location)
        {
            _locationDal.Add(location);
            return new Result(true, Messages.Added);
        }

        public IResult Delete(Location location)
        {
            _locationDal.Delete(location);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<Location> Get(int id)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(b => b.Id == id));
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<LocationDetailDto>> GetLocationDetails()
        {
            return new SuccessDataResult<List<LocationDetailDto>>(_locationDal.GetLocationDetails(), Messages.Listed);
        }

        public IResult Update(Location location)
        {
            _locationDal.Update(location);
            return new SuccessResult(Messages.Updated);
        }
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IDataResult<List<Location>> GetAll();
        IDataResult<List<LocationDetailDto>> GetLocationDetails();
        IDataResult<Location> Get(int id);
        IResult Add(Location location);
        IResult Update(Location location);
        IResult Delete(Location location);
    }
}

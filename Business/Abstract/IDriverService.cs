using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDriverService
    {
        IDataResult<List<Driver>> GetAll();
        IDataResult<Driver> GetById(int id);
        IDataResult<List<Driver>> GetByCarId(int id);
        IResult Add(Driver driver);
        IResult Update(Driver driver);
        IResult Delete(Driver driver);
    }
}

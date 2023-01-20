using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> Get(int id);
        IResult Add(Fuel fuel);
        IResult Update(Fuel fuel);
        IResult Delete(Fuel fuel);
    }
}

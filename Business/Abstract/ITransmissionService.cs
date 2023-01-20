using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        IDataResult<List<Transmission>> GetAll();
        IDataResult<Transmission> Get(int id);
        IResult Add(Transmission transmission);
        IResult Update(Transmission transmission);
        IResult Delete(Transmission transmission);
    }
}

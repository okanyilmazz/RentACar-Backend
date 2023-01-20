using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBodyService
    {
        IDataResult<List<Body>> GetAll();
        IDataResult<Body> Get(int id);
        IResult Add(Body body);
        IResult Update(Body body);
        IResult Delete(Body body);
    }
}

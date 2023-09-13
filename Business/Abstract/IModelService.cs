using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        IDataResult<Model> Get(int id);
        IDataResult<List<Model>> GetByBrandId(int id);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);
    }
}

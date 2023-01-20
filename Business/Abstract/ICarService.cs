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
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetAllByBodyId(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetAllCarDetail();
        IDataResult<List<CarDetailDto>> GetCarDetailById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailByBrandAndColor(int brandId, int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailByBrandAndBody(int brandId, int bodyId);
        IDataResult<List<CarDetailDto>> GetCarDetailByBodyAndColor(int bodyId, int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailByBrandColorAndBody(int brandId, int colorId, int bodyId);
    }
}

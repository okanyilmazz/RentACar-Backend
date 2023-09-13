using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        [CacheRemoveAspect("ICarService.Get")]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(IFormFile file, CarImage carImage, string currentPath)
        {
            var countResult = BusinessRules.Run(CheckImageCount(carImage.Id));
            if (countResult != null)
            {
                return countResult;
            }

            var uploadResult = _fileHelper.Add(file, currentPath);

            if (uploadResult.Success)
            {
                carImage.ImagePath = uploadResult.Message;
                carImage.ImagePath = carImage.ImagePath.Replace(currentPath, "Uploads\\Images\\Cars\\");
            }
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var deleteResult = _fileHelper.Delete(carImage.ImagePath);
            if (deleteResult.Success)
            {
                _carImageDal.Delete(carImage);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }
        [CacheAspect]
        public IDataResult<List<CarImage>> GetByCarId(int id)
        {
            var result = BusinessRules.Run(CheckImageExists(id));
            if (result == null)
            {
                return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
            }
            return new ErrorDataResult<List<CarImage>>(GetDefaultImage().Data);
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var updateResult = _fileHelper.Update(file, carImage.ImagePath);
            if (updateResult.Success)
            {
                carImage.ImagePath = updateResult.Message;

                _carImageDal.Update(carImage);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult CheckImageCount(int id)
        {
            var count = _carImageDal.GetAll(c => c.CarId == id).Count();
            if (count < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult CheckImageExists(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id);
            if (result.Count == 0)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetDefaultImage()
        {
            var result = _carImageDal.GetAll(c => c.ImagePath == PathConstant.DefaultImagePath);
            if (result != null)
            {
                return new SuccessDataResult<List<CarImage>>(result);
            }
            return new ErrorDataResult<List<CarImage>>(Messages.DefaultImageNotExists);
        }


    }
}

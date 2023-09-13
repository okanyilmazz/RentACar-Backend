using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join f in context.Fuels
                             on c.FuelId equals f.Id
                             join t in context.Transmissions
                             on c.TransmissionId equals t.Id
                             join bd in context.Bodies
                             on c.BodyId equals bd.Id
                             join m in context.Models
                             on c.ModelId equals m.Id

                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = b.Id,
                                 ColorId = co.Id,
                                 FuelId = f.Id,
                                 BodyId = bd.Id,
                                 TransmissionId = t.Id,
                                 ModelId = m.Id,
                                 ModelName= m.Name,
                                 Description = c.Description,
                                 BrandName = b.Name,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BodyType = bd.Type,
                                 FuelType = f.FuelType,
                                 TransmissionType = t.TransmissionType,
                                 AirConditioning = c.AirConditioning,
                                 NumberOfPassengers = c.NumberOfPassengers,
                                 Deposit = c.Deposit,
                                 KilometerLimit = c.KilometerLimit,
                                 Availability=c.Availability,
                                 CreditScore=c.CreditScore,
                                 CarImages = ((from ci in context.CarImages
                                               where (c.Id == ci.CarId)
                                               select new CarImage
                                               {
                                                   CarId = ci.CarId,
                                                   Id = ci.Id,
                                                   ImagePath = ci.ImagePath
                                               }).ToList())
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}

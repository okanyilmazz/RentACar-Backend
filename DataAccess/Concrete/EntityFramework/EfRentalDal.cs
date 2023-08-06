using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext rentACarContext = new RentACarContext())
            {
                var result = from r in rentACarContext.Rentals
                             join u in rentACarContext.Users
                             on r.UserId equals u.Id
                             join ca in rentACarContext.Cars
                             on r.CarId equals ca.Id
                             join b in rentACarContext.Brands
                             on ca.BrandId equals b.Id
                             join lRent in rentACarContext.Locations
                             on  r.RentLocationId equals lRent.Id
                             join lReturn in rentACarContext.Locations
                             on r.ReturnLocationId equals lReturn.Id
                             select new RentalDetailDto 
                             {
                                 Id = r.Id,
                                 UserId= u.Id,
                                 BrandName = b.Name,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 RentTime=r.RentTime,
                                 ReturnDate = r.ReturnDate,
                                 ReturnTime = r.ReturnTime,
                                RentLocationId=lRent.Id,
                                ReturnLocationId=lReturn.Id,
                                RentDay=r.RentDay,
                                TotalPrice= r.TotalPrice
                             };
                return result.ToList();
            }
        }

        public List<RentalDetailDto> GetRentalDetailsByUserId(int id)
        {
            return (GetRentalDetails().Where(r=>r.UserId == id).ToList());
        }
    }
}

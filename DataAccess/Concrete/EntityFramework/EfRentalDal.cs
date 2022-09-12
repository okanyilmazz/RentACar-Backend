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
                             join c in rentACarContext.Customers
                             on r.CustomerId equals c.Id
                             join u in rentACarContext.Users
                             on c.UserId equals u.Id
                             join ca in rentACarContext.Cars
                             on r.CarId equals ca.Id
                             join b in rentACarContext.Brands
                             on ca.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 BrandName = b.Name,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate

                             };
                return result.ToList();
            }
        }
    }
}

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
    public class EfLocationDal : EfEntityRepositoryBase<Location, RentACarContext>, ILocationDal
    {
        public List<LocationDetailDto> GetLocationDetails()
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from l in context.Locations
                             join ci in context.Cities
                             on l.CityId equals ci.Id
                             join co in context.Countries
                             on l.CountryId equals co.Id
                             join c in context.Counties
                             on l.CountyId equals c.Id
                             select new LocationDetailDto
                             {
                                 Id = l.Id,
                                 Title = l.Title,
                                 Address = l.Address,
                                 CityName = ci.CityName,
                                 CountryName = co.CountryName,
                                 CountyName = c.CountyName
                             };
                             return result.ToList();
            }
        }
    }
}

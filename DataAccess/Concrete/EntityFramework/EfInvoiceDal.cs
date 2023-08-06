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
    public class EfInvoiceDal : EfEntityRepositoryBase<Invoice, RentACarContext>, IInvoiceDal
    {
        public List<InvoiceDetailDto> GetDetailByUserId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from i in context.Invoices
                             join ci in context.Cities
                             on i.CityId equals ci.Id
                             join co in context.Countries
                             on i.CountryId equals co.Id
                             join c in context.Counties
                             on i.CountyId equals c.Id
                             join u in context.Users
                             on i.UserId equals u.Id
                             where i.UserId == id
                             select new InvoiceDetailDto
                             {
                                 Id = i.Id,
                                 UserId=i.UserId,
                                 Address = i.Address,
                                 CityName = ci.CityName,
                                 CountryName = co.CountryName,
                                 CountyName = c.CountyName
                             };
                return result.ToList();
            }
        }
    }
}

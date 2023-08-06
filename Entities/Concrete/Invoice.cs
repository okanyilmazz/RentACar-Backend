using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Invoice : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public string Address { get; set; }
        public string CompanyTitle { get; set; }
        public string TaxAdministration { get; set; }
        public int TaxNumber { get; set; }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int CountyId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }

    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class LocationDetailDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string CountyName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
    }
}

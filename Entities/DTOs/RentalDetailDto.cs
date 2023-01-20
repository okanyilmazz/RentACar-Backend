using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RentDate { get; set; }
        public string RentTime { get; set; }
        public int RentLocationId { get; set; }
        public string ReturnDate { get; set; }
        public string ReturnTime { get; set; }
        public int ReturnLocationId { get; set; }
        public int RentDay { get; set; }
        public double TotalPrice { get; set; }

        
    }
}

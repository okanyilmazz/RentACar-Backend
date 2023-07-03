using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
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



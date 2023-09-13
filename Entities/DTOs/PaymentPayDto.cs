using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PaymentPayDto
    {
        public int Id { get; set; }
        public Payment Payment { get; set; }
        public double TotalPrice { get; set; }
    }
}

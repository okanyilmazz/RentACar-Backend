using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int FuelId { get; set; }
        public int BodyId { get; set; }
        public int TransmissionId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string FuelType { get; set; }
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public int ModelYear { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool AirConditioning { get; set; }
        public double Deposit { get; set; }
        public int KilometerLimit { get; set; }
        public bool Availability { get; set; }
        public List<CarImage> CarImages { get; set; }
    }
}

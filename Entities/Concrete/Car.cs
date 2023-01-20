using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int FuelId { get; set; }
        public int BodyId { get; set; }
        public int TransmissionId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int NumberOfPassengers { get; set; }
        public bool AirConditioning { get; set; }
        public double Deposit { get; set; }
        public int KilometerLimit { get; set; }
        public bool Availability { get; set; }
    }
}

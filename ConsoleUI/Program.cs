using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            //GetAll

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------------------------");


            //Add Car
            Car newCar = new Car
            {
                BrandId = 3,
                ColorId = 2,
                DailyPrice = 1500,
                Description = "Yeni araba",
                ModelYear = 2055,
                Id = 3

            };

            carManager.Add(newCar);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------------------------");

            //Update Car

            Car updateCar = new Car
            {
                BrandId = 3,
                ColorId = 2,
                DailyPrice = 1500,
                Description = "Yenilendi bu araba",
                ModelYear = 2055,
                Id = 2
            };
            carManager.Update(updateCar);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------------------------");


            //Delete Car

            Car deleteCar = new Car
            {
                BrandId = 3,
                ColorId = 2,
                DailyPrice = 1500,
                Description = "Yenilendi bu araba",
                ModelYear = 2055,
                Id = 2
            };
            carManager.Delete(deleteCar);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------------------------");

            //GetById

            Console.WriteLine(carManager.GetById(3).Description);
            Console.WriteLine("--------------------------------------");

        }
    }
}

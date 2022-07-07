using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odev7Gun();
            //Odev8Gun();
            // Odev9Gun();
            //Odev10Gun();
           
        }

     

        private static void Odev10Gun()
        {
            //UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User
            //{
            //    Email = "test@test.com",
            //    Id = 1,
            //    FirstName = "Ahmet",
            //    LastName = "Veli",
            //    Password = "123456"
            //});
            //userManager.Add(new User
            //{
            //    Email = "AliVeli@test.com",
            //    Id = 2,
            //    FirstName = "Ali",
            //    LastName = "Veli",
            //    Password = "654321"
            //});
            //userManager.Add(new User
            //{
            //    Email = "CengizOzkan@test.com",
            //    Id = 3,
            //    FirstName = "Cengiz",
            //    LastName = "Özkan",
            //    Password = "0203010203"
            //});

            //var result2 = userManager.Add(new User
            //{
            //    Email = "OzanCentikli@test.com",
            //    Id = 4,
            //    FirstName = "Ozan",
            //    LastName = "Çentikli",
            //    Password = "050505"
            //});

            //if (result2.Success)
            //{
            //    Console.WriteLine(result2.Message);
            //}

            //var result = userManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var user in userManager.GetAll().Data)
            //    {
            //        Console.WriteLine(user.FirstName + " / " + user.LastName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "Ahmet Ltd. Şti.",
                Id = 1,
                UserId = 1
            });

        }



        //private static void Odev7Gun()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());

        //    //GetAll

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("--------------------------------------");


        //    //Add Car
        //    Car newCar = new Car
        //    {
        //        BrandId = 3,
        //        ColorId = 2,
        //        DailyPrice = 1500,
        //        Description = "Yeni araba",
        //        ModelYear = 2055,
        //        Id = 3

        //    };

        //    carManager.Add(newCar);

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("--------------------------------------");

        //    //Update Car

        //    Car updateCar = new Car
        //    {
        //        BrandId = 3,
        //        ColorId = 2,
        //        DailyPrice = 1500,
        //        Description = "Yenilendi bu araba",
        //        ModelYear = 2055,
        //        Id = 2
        //    };
        //    carManager.Update(updateCar);
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("--------------------------------------");


        //    //Delete Car

        //    Car deleteCar = new Car
        //    {
        //        BrandId = 3,
        //        ColorId = 2,
        //        DailyPrice = 1500,
        //        Description = "Yenilendi bu araba",
        //        ModelYear = 2055,
        //        Id = 2
        //    };
        //    carManager.Delete(deleteCar);
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("--------------------------------------");

        //    //GetById

        //    // Console.WriteLine(carManager.GetById(3).Description);
        //    Console.WriteLine("--------------------------------------");




        //    ////////////////////////////////////////////////////////////////////////////////////////////////////////////// EntityFramework //////////////////////////////////

        //    /*
        //   carManager.Add(new Car
        //   {
        //       Id = 3,
        //       BrandId = 2,
        //       ColorId = 2,
        //       DailyPrice = 500,
        //       Description = "Passat Araba",
        //       ModelYear = 2021
        //   });*/
        //}
        //private static void Odev8Gun()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    Console.WriteLine("---CAR - GET ALL---");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("\n");


        //    Console.WriteLine("---BRAND ID---");
        //    foreach (var car in carManager.GetAllByBrandId(2))
        //    {
        //        Console.WriteLine("Araba açıklaması : " + car.Description);
        //        Console.WriteLine("Markası : " + brandManager.Get(2).Name);
        //    }
        //    Console.WriteLine("\n");

        //    Console.WriteLine("---CAR GET ALL COLOR ID---");
        //    foreach (var car in carManager.GetAllByColorId(2))
        //    {
        //        Console.WriteLine("Araba açıklaması : " + car.Description);
        //        Console.WriteLine("Rengi : " + colorManager.GetById(2).Name);
        //    }
        //    Console.WriteLine("\n");

        //    /*
        //    colorManager.Add(new Color
        //    {
        //        Id = 1,
        //        Name="Kırmızı"
        //    });
        //    colorManager.Add(new Color
        //    {
        //        Id = 2,
        //        Name = "Sarı"
        //    });
        //    colorManager.Add(new Color
        //    {
        //        Id = 3,
        //        Name = "Siyah"
        //    });
        //    */
        //    Console.WriteLine("---COLOR - GET ALL---");


        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.Name);
        //    }

        //    Console.WriteLine("\n");



        //    /*
        //    brandManager.Add(new Brand
        //    {
        //        Id = 1,
        //        Name = "Audi"
        //    });
        //    brandManager.Add(new Brand
        //    {
        //        Id = 2,
        //        Name = "Passat"
        //    });
        //    brandManager.Add(new Brand
        //    {
        //        Id = 3,
        //        Name = "BMW"
        //    });*/

        //    Console.WriteLine("---BRAND - GET ALL---");
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.Name);
        //    }
        //}
        //private static void Odev9Gun()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());



        //    Console.WriteLine("ID'si 1 olan marka : " + brandManager.Get(1).Name);
        //    /*
        //    brandManager.Add(new Brand
        //    {
        //        Id = 4,
        //        Name = "Volvo"
        //    });*/
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.Name);
        //    }



        //    Console.WriteLine("ID'si 1 olan renk : " + colorManager.GetById(1).Name);

        //    /* colorManager.Add(new Color
        //     {
        //         Id = 4,
        //         Name = "Turkuaz"

        //     });*/
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.Name);
        //    }

        //    Console.WriteLine("ID'si 1 olan araba : " + carManager.GetById(1).Description);

        //    /* carManager.Add(new Car
        //     {
        //         Id = 4,
        //         BrandId = 4,
        //         ColorId = 4,
        //         DailyPrice = 250,
        //         Description = "Volvo bir araba",
        //         ModelYear = 2022
        //     });*/

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }


        //    Console.WriteLine(" -------CAR DETAILS \n");

        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine("Car Description : {0} Car Brand : {1} Car Color : {2} Car Daily Price : {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
        //    }

        //}

        private static void RentalSimulation()
        {/*
            UserManager userManager = new UserManager(new EfUserDal());
            CarManager carManager = new CarManager(new EfCarDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Console.WriteLine("ARABA KİRALAMA SİMÜLASYONU : \n\n ");

            Console.WriteLine("Kullanıcı Adı giriniz");
            string account = Console.ReadLine();

            Console.WriteLine("Şifre giriniz");
            string password = Console.ReadLine();


            var result = userManager.GetAll().Data.Exists(u => u.FirstName == account & u.Password == password);

            if (result)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.Id + " " + car.Description + " " + car.DailyPrice);
                }

                Console.WriteLine("Kiralamak istediğiniz arabanın numarasını giriniz");
                int carId = Convert.ToInt32(Console.ReadLine());

                rentalManager.Add(new Rental
                {

                });

            }*/
        }
    }
}

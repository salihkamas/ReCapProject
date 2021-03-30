using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarDetailsTest();
            //GetAllTest();
            //GetByIdTest();
            //HataDenemeFiyat();
            //HataDenemeIsim();
            //GetByBrandIdTest();
            //GetByColorIdTest();
        }

        private static void GetByColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("White Cars\n----------");
            var result = carManager.GetByColorId(1);
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Renault Cars\n------------");
            var result = carManager.GetByBrandId(3);
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void HataDenemeIsim()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                BrandId = 1,
                CarName = "C",
                ColorId = 4,
                DailyPrice = 348,
                Description = "Hata Deneme",
                ModelYear = "2018"
            };
            var result = carManager.Add(car);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void HataDenemeFiyat()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                BrandId = 1,
                CarName = "Corsa",
                ColorId = 4,
                DailyPrice = 0,
                Description = "Hata Deneme",
                ModelYear = "2018"
            };
            var result = carManager.Add(car);
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(1);
            Console.WriteLine(result.Data.CarName);
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarId} {car.CarName} {car.BrandId} {car.ColorId} {car.DailyPrice} {car.Description}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarsDetails();
            if (result.Success)
            {
                Console.WriteLine("Name                 Brand      Color      DailyPrice");
                Console.WriteLine("----                 -----      -----      ----------");
                foreach (var car in result.Data)
                {
                    Console.WriteLine($"{car.CarName} {car.BrandName} {car.ColorName} {car.DailyPrice}TL");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

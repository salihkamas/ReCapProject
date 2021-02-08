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
            foreach (var car in carManager.GetByColorId(1))
            {
                Console.WriteLine($"{car.CarName}");
            }
        }

        private static void GetByBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Renault Cars\n------------");
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine($"{car.CarName}");
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
            carManager.Add(car);
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
            carManager.Add(car);
        }

        private static void GetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1).CarName);
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarId} {car.CarName} {car.BrandId} {car.ColorId} {car.DailyPrice} {car.Description}");
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Name                 Brand      Color      DailyPrice");
            Console.WriteLine("----                 -----      -----      ----------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarName} {car.BrandName} {car.ColorName} {car.DailyPrice}TL");
            }
        }
    }
}

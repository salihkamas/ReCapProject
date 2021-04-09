using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {

        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandId = b.BrandId, ColorId = clr.ColorId, CarName = c.CarName, BrandName = b.BrandName, ColorName = clr.ColorName, DailyPrice = c.DailyPrice, Description = c.Description, Status = !context.Rentals.Any(r => r.CarId == c.CarId && r.ReturnDate == null), FindexPoint = c.FindexPoint };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();

            }
        }

        public CarDetailDto GetCarDetails(int carId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars.Where(c => c.CarId == carId)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandId = b.BrandId, ColorId = clr.ColorId, CarName = c.CarName, BrandName = b.BrandName, ColorName = clr.ColorName, DailyPrice = c.DailyPrice, Description = c.Description, Status = !context.Rentals.Any(r => r.CarId == c.CarId && r.ReturnDate == null) };
                return result.SingleOrDefault();

            }
        }

    }
}

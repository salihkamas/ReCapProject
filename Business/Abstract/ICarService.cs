﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetByBrandIdAndColorId(int brandId, int colorId);
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarsDetails();
        IDataResult<CarDetailDto> GetCarDetails(int carId);

        IResult AddTransactionalTest(Car car);

    }
}

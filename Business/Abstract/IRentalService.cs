using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult<Rental> GetByCustomerId(int customerId);
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}

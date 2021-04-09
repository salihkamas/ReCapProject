using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICustomerDal _customerDal;
        ICarDal _carDal;
        public RentalManager(IRentalDal rentalDal, ICustomerDal customerDal, ICarDal carDal)
        {
            _rentalDal = rentalDal;
            _customerDal = customerDal;
            _carDal = carDal;
        }

        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(CheckCarAvailable(rental), CheckFindexPoint(rental.CustomerId, rental.CarId));
            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.SuccesDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.SuccesListed);
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId));
        }

        public IDataResult<Rental> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CustomerId == customerId));
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.SuccesUpdated);
        }
        private IResult CheckCarAvailable(Rental rental)
        {
            var result = _rentalDal.Get(r => (r.CarId == rental.CarId && r.ReturnDate == null));

            if (result != null)
            {
                return new ErrorResult(Messages.RentalError);

            }
            return new SuccessResult();
        }

        private IResult CheckFindexPoint(int customerId, int carId)
        {
            var car = _carDal.Get(c => c.CarId == carId);
            var customer = _customerDal.Get(c => c.CustomerId == customerId);

            if (customer.FindexPoint >= car.FindexPoint)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.FindexPointNotEnough);
        }
    }

}

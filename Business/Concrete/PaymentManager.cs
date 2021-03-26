using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult Payment(Payment payment)
        {
            if (payment.Amount>3000)
            {
                return new ErrorResult("Available balance error");
            }
            return new SuccessResult("Payment successful");
        }
    }
}

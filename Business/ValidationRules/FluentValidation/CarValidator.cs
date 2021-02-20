using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().WithMessage("Car name cannot be empty");
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Car name must be at least two characters long");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Daily Price cannot be empty");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Daily price must be greater than zero");
        }
    }
}

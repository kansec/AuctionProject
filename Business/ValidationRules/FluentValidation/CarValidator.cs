using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelId).NotEmpty();
            RuleFor(c => c.Year).NotEmpty();
            RuleFor(c => c.ColourId).NotEmpty();
            RuleFor(c => c.Mileage).NotEmpty();
            RuleFor(c => c.AuctionId).NotEmpty();


            RuleFor(c => c.Year).GreaterThanOrEqualTo(1940);
            RuleFor(c => c.Mileage).GreaterThanOrEqualTo(0);
        }

    }
}

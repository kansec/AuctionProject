using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AuctionValidator :AbstractValidator<Auction>
    {
        public AuctionValidator()
        {
            RuleFor(a => a.Title).NotEmpty();
            RuleFor(a => a.Description).NotEmpty();
            RuleFor(a => a.StartDate).NotEmpty();
            RuleFor(a => a.EndDate).NotEmpty();
            RuleFor(a => a.IsActive).NotEmpty();

            RuleFor(a => a.StartDate).GreaterThanOrEqualTo(DateTime.Now);
            RuleFor(a => a.EndDate).GreaterThanOrEqualTo(a => a.StartDate);

            

        }
    }
}

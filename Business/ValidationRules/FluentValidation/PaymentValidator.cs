using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator: AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.CardNumber).NotEmpty();
            RuleFor(p => p.CardName).NotEmpty();
            RuleFor(p => p.CardMonth).NotEmpty();
            RuleFor(p => p.CardYear).NotEmpty();
            RuleFor(p => p.CardSecurityCode).NotEmpty();
        }
    }
}

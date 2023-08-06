using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    internal class InvoiceValidator : AbstractValidator<Invoice>
    {
        public InvoiceValidator()
        {
            RuleFor(r => r.CountryId).NotEmpty();
            RuleFor(r => r.CityId).NotEmpty();
            RuleFor(r => r.CountyId).NotEmpty();
            RuleFor(r => r.Address).NotEmpty();

        }

    }
}

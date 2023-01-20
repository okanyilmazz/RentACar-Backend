using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.FullName).NotEmpty();
            RuleFor(c => c.FullName).MaximumLength(150);
            RuleFor(c => c.Mail).NotEmpty();
            RuleFor(c => c.Mail).MaximumLength(150);
            RuleFor(c => c.Subject).NotEmpty();
            RuleFor(c => c.Subject).MaximumLength(50);
            RuleFor(c => c.Message).NotEmpty();
            RuleFor(c => c.Message).MaximumLength(300);
        }
    }
}

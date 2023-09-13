using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ModelValidator:AbstractValidator<Model>
    {
        public ModelValidator() { 
        
            RuleFor(x => x.Name).NotEmpty();    
            RuleFor(x => x.BrandId).NotEmpty();    
        }
    }
}

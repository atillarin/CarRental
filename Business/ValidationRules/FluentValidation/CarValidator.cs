using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).GreaterThan(1900);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.Description).Must(MaximumLength).WithMessage("En fazla 30 karakter olmalıdır");
        }

        private bool MaximumLength(string arg)
        {
            return arg.Length == 30;
        }
    }
}

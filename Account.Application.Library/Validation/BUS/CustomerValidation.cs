using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class CustomerValidation : AbstractValidator<CustomerDTO>
    {
        public CustomerValidation()
        {
            RuleFor(person => person.FullName)
                .NotNull()
                .MaximumLength(100);
        }
    }
}

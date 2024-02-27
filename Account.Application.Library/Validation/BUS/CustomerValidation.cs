using Account.Application.Library.Models.DTOs.BUS;
using Account.Domain.Library.Entities.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class CustomerValidation : AbstractValidator<CustomerDTO>
    {
        public CustomerValidation()
        {
            RuleFor(customer => customer.FullName)
                .NotNull().WithMessage("نام مشترک خالی است")
                .NotEmpty().WithMessage("نام مشترک درج نشده است")
                .MinimumLength(5).WithMessage("نام مشترک حداقل 5 حرف باید باشد")
                .MaximumLength(100).WithMessage("نام مشترک حداکثر 100 حرف باید باشد")
                ;

            RuleFor(customer => customer.Picture)
                .NotNull().WithMessage("عکس مشترک خالی است")
                .NotEmpty().WithMessage("عکس مشترک درج نشده است")
                ;
        }
    }
}

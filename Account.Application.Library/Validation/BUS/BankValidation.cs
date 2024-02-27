using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class BankValidation : AbstractValidator<BankDTO>
    {
        public BankValidation()
        {
            RuleFor(x => x.BankName)
                .NotNull().WithMessage("نام بانک الزاما پر شود")
                .NotEmpty().WithMessage("نام بانک خالی است")
                .MinimumLength(3).WithMessage("نام بانک حداقل 3 حرف باید باشد")
                .MaximumLength(20).WithMessage("نام بانک حداکثر 20 حرف باید باشد")
                ;
        }
    }
}

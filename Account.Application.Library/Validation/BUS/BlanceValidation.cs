using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class BlanceValidation: AbstractValidator<BlanceDTO>
    {
        public BlanceValidation()
        {
            RuleFor(x => x.TransactionID)
                .NotEmpty().WithMessage("کلید تراکنش ساخته نشده است")
                .NotNull().WithMessage("کلید تراکنش موجود نیست")
                ;
            RuleFor(x => x.CartID)
                .NotEmpty().WithMessage("کارت برای این تراکنش انتخاب نشده است")
                .NotNull().WithMessage("کارت برای این تراکنش انتخاب نشده است")
                ;
            RuleFor(x => x.BlanceType)
                .NotEmpty().WithMessage("نوع موجودی را انتخاب کنید")
                .NotNull().WithMessage("نوع حساب را انتخاب کنید")
                ;
            RuleFor(x => x.OldBlanceCash)
                .NotNull().WithMessage("موجودی قبلی دریافت نشده است")
                ;
            RuleFor(x => x.NewBlanceCash)
                .NotEmpty().WithMessage("موجودی جدید محاسبه نشده است")
                .NotNull().WithMessage("محاسبه موجودی انجام نشده است")
                ;
            RuleFor(x => x.TransactionCash)
                .NotEmpty().WithMessage("مبلغ برای این تراکنش را پر کنید")
                .NotNull().WithMessage("مبلغ تراکنش را بنویسید")
                ;
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("توضیحات برای این تراکنش را پر کنید")
                .NotNull().WithMessage("توضیحات برای این تراکنش را پر کنید")
                ;
            
        }

    }
}

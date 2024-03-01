using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class CartValidation: AbstractValidator<CartDTO>
    {
        public CartValidation()
        {
            RuleFor(x => x.AccountNumber)
                .NotNull().WithMessage("شماره کارت خالی است")
                .NotEmpty().WithMessage("شماره کارت پر نشده است")
                //.MaximumLength(20).WithMessage("شماره کارت حداکثر 16 عدد است")
                .MinimumLength(16).WithMessage("شماره کارت حداقل 16 عدد است")
                ;
            RuleFor(x => x.ShabaAccountNumber)
                .NotNull().WithMessage("شبا کارت خالی است")
                .NotEmpty().WithMessage("شبا کارت پر نشده است")
                ;
            RuleFor(x => x.ExpireDate)
                .NotNull().WithMessage("تاریخ انقضاء درج نشده است")
                .NotEmpty().WithMessage("تاریخ انقضاء انتخاب نشده است")
                ;
            RuleFor(x => x.BankID)
                .NotNull().WithMessage("بانک برای کارت انتخاب نشده است")
                .NotEmpty().WithMessage("بانک برای کارت انتخاب نشده است")
                ;
            RuleFor(x => x.CustomerID)
                .NotNull().WithMessage("مشترک مالک این کارت را انتخاب کنید")
                .NotEmpty().WithMessage("مشترک مالک این کارت را انتخاب کنید")
                ;
            //RuleFor(x => x.ParentID)
            //    .NotNull()
            //    .NotEmpty();
            RuleFor(x => x.CartType)
                .NotNull().WithMessage("نوع کارت را انتخاب کنید")
                .NotEmpty().WithMessage("نوع کارت را انتخاب کنید")
                ;
            RuleFor(x => x.Picture)
                .NotNull().WithMessage("تصویر کارت انتخاب نشده است")
                .NotEmpty().WithMessage("انتخاب تصویر برای کارت الزامی میباشد")
                ;
        }
    }
}

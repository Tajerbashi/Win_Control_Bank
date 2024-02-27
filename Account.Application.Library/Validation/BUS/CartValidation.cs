using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class CartValidation: AbstractValidator<CartDTO>
    {
        public CartValidation()
        {
            RuleFor(x => x.AccountNumber).NotNull().NotEmpty();
            RuleFor(x => x.ShabaAccountNumber).NotNull().NotEmpty();
            RuleFor(x => x.ExpireDate).NotNull().NotEmpty();
            RuleFor(x => x.BankID).NotNull().NotEmpty();
            RuleFor(x => x.CustomerID).NotNull().NotEmpty();
            RuleFor(x => x.ParentID).NotNull().NotEmpty();
            RuleFor(x => x.CartType).NotNull().NotEmpty();
            RuleFor(x => x.Key).NotNull().NotEmpty();
            RuleFor(x => x.Picture).NotNull().NotEmpty();
        }
    }
}

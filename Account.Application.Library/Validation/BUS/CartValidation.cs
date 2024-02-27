using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class CartValidation: AbstractValidator<CartDTO>
    {
        public CartValidation() { }
    }
}

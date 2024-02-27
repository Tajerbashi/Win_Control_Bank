using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class BlanceValidation: AbstractValidator<BlanceDTO>
    {
        public BlanceValidation()
        {
            RuleFor(x => x.TransactionID).NotEmpty().NotNull();
            RuleFor(x => x.CartID).NotEmpty().NotNull();
            RuleFor(x => x.BlanceType).NotEmpty().NotNull();
            RuleFor(x => x.OldBlanceCash).NotEmpty().NotNull();
            RuleFor(x => x.NewBlanceCash).NotEmpty().NotNull();
            RuleFor(x => x.TransactionCash).NotEmpty().NotNull();
            RuleFor(x => x.Description).NotEmpty().NotNull();
        }

    }
}

using Account.Application.Library.Models.DTOs.BUS;
using FluentValidation;

namespace Account.Application.Library.Validation.BUS
{
    public class SettlemantValidation : AbstractValidator<SettlemantDTO>
    {
        public SettlemantValidation()
        {
            RuleFor(x => x.TransactionID).NotNull().NotEmpty();
        }
    }
}

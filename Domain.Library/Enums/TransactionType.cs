using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum TransactionType : byte
    {
        [Description("خرید")]
        Buy = 0,
        [Description("واریز")]
        Settlemant = 1,
        [Description("برداشت")]
        Harvesting = 2,


    }
}

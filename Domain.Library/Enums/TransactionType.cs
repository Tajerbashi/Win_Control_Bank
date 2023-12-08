using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum TransactionType : byte
    {
        /// <summary>
        /// واریز
        /// </summary>
        [Description("واریز")]
        Settlemant = 1,
        /// <summary>
        /// برداشت
        /// </summary>
        [Description("برداشت")]
        Harvesting = 2,
        

    }
    public enum BlanceType : byte
    {
        /// <summary>
        /// نقدی
        /// </summary>
        [Description("نقدی")]
        Cashable = 1,
        /// <summary>
        /// بانکی
        /// </summary>
        [Description("بانکی")]
        Banking = 2,
        

    }

}

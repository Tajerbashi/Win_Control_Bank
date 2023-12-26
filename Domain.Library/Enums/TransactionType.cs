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
}

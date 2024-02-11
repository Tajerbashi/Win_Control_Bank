using System.ComponentModel;

namespace Account.Domain.Library.Enums
{
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

using System.ComponentModel;

namespace Account.Domain.Library.Enums
{
    public enum CartType : byte
    {
        /// <summary>
        /// مشترک
        /// </summary>
        [Description("مشترک")]
        Main = 1,
        /// <summary>
        /// فرعی
        /// </summary>
        [Description("فرعی")]
        Custome = 2,


    }
}

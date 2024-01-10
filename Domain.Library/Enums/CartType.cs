using System.ComponentModel;

namespace Domain.Library.Enums
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

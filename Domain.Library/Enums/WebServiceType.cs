using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum WebServiceType : byte
    {
        /// <summary>
        /// سوپ
        /// </summary>
        [Description("سوپ")]
        Soap = 1,
        /// <summary>
        /// رست
        /// </summary>
        [Description("رست")]
        Rest = 2,


    }

}

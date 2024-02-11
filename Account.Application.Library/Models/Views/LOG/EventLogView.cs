using Account.Common.Library.Utilities;
using Account.Domain.Library.Enums;
using Account.Application.Library.BaseModels;

namespace Account.Application.Library.Models.Views.LOG
{
    public class EventLogView : BaseView
    {
        public TransactionType TransactionType { get; set; }

        public BlanceType BlanceType { get; set; }

        public string Accounter { get; set; }

        public double Blance { get; set; }

        public double Cash { get; set; }

        public long CartID { get; set; }

        public override string ToString()
        {

            return ($@"کارت {Accounter} با موجودی {Blance} به مبلغ {Cash} با تراکنش {EnumExtensionMethods.GetEnumDescription(TransactionType)} از نوع حساب {BlanceType} عملیات داشت");
        }
    }
}

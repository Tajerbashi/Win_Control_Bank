using Account.Common.Library.Utilities;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Enums;
using Account.Infrastructure.Library.BaseModels;

namespace Account.Infrastructure.Library.Models.DTOs.LOG
{
    public class EventLogDTO : BaseDTO
    {
        public TransactionType TransactionType { get; set; }

        public BlanceType BlanceType { get; set; }

        public string Accounter { get; set; }

        public double Blance { get; set; }

        public double Cash { get; set; }
        
        public long CartID { get; set; }

        public override string ToString()
        {

            return ($@"کارت {Accounter} با موجودی {Blance} به مبلغ {Cash} با تراکنش {EnumExtensionMethods.GetEnumDescription(TransactionType)} از نوع حساب {EnumExtensionMethods.GetEnumDescription(BlanceType)} عملیات داشت");
        }
    }
}

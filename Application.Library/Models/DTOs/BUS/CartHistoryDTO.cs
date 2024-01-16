using Common.Library.Utilities;
using Domain.Library.Enums;
using Infrastructure.Library.BaseModels;

namespace Infrastructure.Library.Models.DTOs.BUS
{
    public class CartHistoryDTO : BaseDTO
    {
        public TransactionType TransactionType { get; set; }

        public BlanceType BlanceType { get; set; }

        public double Cash { get; set; }

        public bool IsCashable { get; set; }

        public Guid? FromCartKey { get; set; }

        public Guid? ToCartKey { get; set; }

        public string Message { get; set; }

        public long CartID { get; set; }

        public long BlanceID { get; set; }

        public long TransactionID { get; set; }

        public override string ToString()
        {
            return ($@"تراکنش {TransactionID} برای کارت {CartID} با موجودی {BlanceID} و مبلغ {Cash} با نوع موجود {EnumExtensionMethods.GetEnumDescription(BlanceType)} و نوع تراکنش {EnumExtensionMethods.GetEnumDescription(TransactionType)} انجام شد");
        }
    }
}

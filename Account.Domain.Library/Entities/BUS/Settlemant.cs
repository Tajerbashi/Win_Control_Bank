using Account.Domain.Library.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Domain.Library.Entities.BUS
{
    [Table("Settlemants", Schema = "BUS")]
    public class Settlemant : BaseEntity
    {
        [Description("سال")]
        public int Year { get; set; }
        [Description("ماه")]
        public byte Month { get; set; }
        [Description("روز")]
        public byte Day { get; set; }
        [Description("کلید تراکنش")]
        public Guid TransactionID { get; set; }
        [Description("مبلغ")]
        public double Cash { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Cart"),Description("کلید کارت")]
        public long CartID { get; set; }
        public Cart Cart { get; set; }
    }
}

using Domain.Library.Entities.BUS;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class TransactionRepository : GenericRepository<Transaction, TransactionDTO, TransactionView>, IGenericQueries
    {
        protected TransactionRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected TransactionRepository(ContextDbApplication context): base(context){}
        public string GetCount()
        {
            return ($@"
SELECT COUNT(TR.Id)
FROM BUS.Transactions TR
INNER JOIN BUS.Carts CT ON TR.CartID = CT.ID 
INNER JOIN BUS.Banks BK ON BK.ID = CT.BankID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID
WHERE TR.IsDeleted = 0
");
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            return ($@"
SELECT 
TR.ID AS [آیدی] ,
BK.BankName AS [بانک],
CASE TR.TransactionType
WHEN 1 THEN N'واریزی'
WHEN 2 THEN N'برداشت'
ELSE N'' END AS [نوع تراکنش],
FORMAT(CAST(TR.Cash as bigint),'###,###,###') AS [مبلغ تراکنش],
CS.FullName AS [حساب],
CT.AccountNumber AS [کارت],
CASE CT.CartType 
WHEN 1 THEN N'مشترک'
WHEN 2 THEN N'فرعی'
ELSE N'تعیین نشده' 
END AS [نوع حساب],
(SELECT (SELECT CS1.FullName FROM BUS.Customers CS1 WHERE CC.CustomerID = CS1.ID) FROM BUS.Carts CC WHERE CC.ID = CT.ParentID) AS [والد],
FORMAT(CAST(BL.BlanceCash as bigint),'###,###,###') AS [موجودی],
CASE BL.BlanceType
WHEN 1 THEN N'نقدی'
WHEN 2 THEN N'بانکی'
ELSE N'تعیین نشده' END AS [نوع موجودی]
FROM BUS.Transactions TR
INNER JOIN BUS.Carts CT ON TR.CartID = CT.ID 
INNER JOIN BUS.Banks BK ON BK.ID = CT.BankID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID
WHERE TR.IsDeleted = 0
ORDER BY TR.ID DESC 
{paging}
");
        }
        public string ShowAllByCartId(long cartId,string paging)
        {
            return ($@"
SELECT 
TR.ID AS [آیدی] ,
BK.BankName AS [بانک],
CASE TR.TransactionType
WHEN 1 THEN N'واریزی'
WHEN 2 THEN N'برداشت'
ELSE N'' END AS [نوع تراکنش],
FORMAT(CAST(TR.Cash as bigint),'###,###,###') AS [مبلغ تراکنش],
CS.FullName AS [حساب],
CT.AccountNumber AS [کارت],
CASE CT.CartType 
WHEN 1 THEN N'مشترک'
WHEN 2 THEN N'فرعی'
ELSE N'تعیین نشده' 
END AS [نوع حساب],
(SELECT (SELECT CS1.FullName FROM BUS.Customers CS1 WHERE CC.CustomerID = CS1.ID) FROM BUS.Carts CC WHERE CC.ID = CT.ParentID) AS [والد],
FORMAT(CAST(BL.BlanceCash as bigint),'###,###,###') AS [موجودی],
CASE BL.BlanceType
WHEN 1 THEN N'نقدی'
WHEN 2 THEN N'بانکی'
ELSE N'تعیین نشده' END AS [نوع موجودی]
FROM BUS.Transactions TR
INNER JOIN BUS.Carts CT ON TR.CartID = CT.ID AND CT.ID = {cartId}
INNER JOIN BUS.Banks BK ON BK.ID = CT.BankID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID
WHERE TR.IsDeleted = 0
ORDER BY TR.ID DESC 
{paging}
");
        }
        public string Show50LastTransactions()
        {
            return (@"
SELECT TOP(50)
TR.ID AS [آیدی] ,
BK.BankName AS [بانک],
CASE TR.TransactionType
WHEN 1 THEN N'واریزی'
WHEN 2 THEN N'برداشت'
ELSE N'' END AS [نوع تراکنش],
FORMAT(CAST(TR.Cash as bigint),'###,###,###') AS [مبلغ تراکنش],
CS.FullName AS [حساب],
CT.AccountNumber AS [کارت],
CASE CT.CartType 
WHEN 1 THEN N'مشترک'
WHEN 2 THEN N'فرعی'
ELSE N'تعیین نشده' 
END AS [نوع حساب],
(SELECT (SELECT CS1.FullName FROM BUS.Customers CS1 WHERE CC.CustomerID = CS1.ID) FROM BUS.Carts CC WHERE CC.ID = CT.ParentID) AS [والد],
FORMAT(CAST(BL.BlanceCash as bigint),'###,###,###') AS [موجودی],
CASE BL.BlanceType
WHEN 1 THEN N'نقدی'
WHEN 2 THEN N'بانکی'
ELSE N'تعیین نشده' END AS [نوع موجودی]
FROM BUS.Transactions TR
INNER JOIN BUS.Carts CT ON TR.CartID = CT.ID 
INNER JOIN BUS.Banks BK ON BK.ID = CT.BankID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID
WHERE TR.IsDeleted = 0
ORDER BY TR.ID DESC
");
        }
        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            List<KeyValue<long>> result = new List<KeyValue<long>>()
            {
                new KeyValue<long> { Value = 1 ,Key = "واریز"},
                new KeyValue<long> { Value = 2 ,Key = "برداشت"},
            };

            return result;
        }
        public IEnumerable<KeyValue<long>> TitleValueKind()
        {
            return new List<KeyValue<long>>()
            {
                new KeyValue<long> { Value = 1 ,Key = "خرید از کارت"},
                new KeyValue<long> { Value = 2 ,Key = "برداشت نقدی"},
                new KeyValue<long> { Value = 3 ,Key = "انتقال به کارت دیگر"},
                new KeyValue<long> { Value = 4 ,Key = "واریز به کارت"},
            };
        }
    }
}

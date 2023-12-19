using AutoMapper;
using Azure;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CartRepository : GenericRepository<Cart, CartDTO, CartView>, IGenericQueries
    {
        protected CartRepository(IMapper mapper) : base(mapper)
        {
        }

        public string GetCount()
        {
            return (@"
SELECT 
	COUNT (*) AS [COUNT]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Transactions T ON T.CartID = C.ID
INNER JOIN BUS.Blances B ON B.TransactionID = T.ID
WHERE C.IsDeleted = 0
");
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.BlanceCash as bigint),'###,###,###') AS [موجودی],
	Case T.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'موجودی'
	,
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Transactions T ON T.CartID = C.ID
INNER JOIN BUS.Blances B ON B.TransactionID = T.ID
WHERE C.IsDeleted = 0
ORDER BY C.ID DESC 
{paging}
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return _context.Carts.Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.Title} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValueByUser(long Id)
        {
            return _context.Carts.Where(x => x.CustomerID == Id).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.Title} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
    }
}

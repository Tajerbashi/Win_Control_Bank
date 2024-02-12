using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Patterns;

namespace Account.Application.Library.Repositories.BUS
{
    public class CartRepository : GenericRepository<Cart, CartDTO, CartView>, ICartRepository
    {
        public CartRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected CartRepository(ContextDbApplication context)
          : base(context)
        {
        }
        public string GetCount()
        {
            return (@"
SELECT 
	COUNT (C.ID) AS [COUNT]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID AND B.IsActive = 1
WHERE C.IsDeleted = 0
");
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }
        public string SearchByCartId(long Id, string paging)
        {
            return (@$"
SELECT 
	BN.BankName AS [بانک],
	CS.FullName AS [مالک],
	C.AccountNumber AS [شماره حساب],
	C.ShabaAccountNumber AS [شماره شبا],
	FORMAT(C.[ExpireDate],'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ انقضاء],
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
AND C.Id = {Id}
ORDER BY C.ID DESC 
{paging}
");
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
	FORMAT(CAST(B.NewBlanceCash as bigint),'###,###,###') AS [موجودی],
	Case B.TransactionType
	WHEN 1 THEN N'واریز'
	ELSE N'برداشت'
	END N'تراکنش'
	,
	Case B.BlanceType
	WHEN 1 THEN N'نقدی'
	ELSE N'بانکی'
	END N'نوع موجودی',
	CASE C.IsActive
	WHEN 1 THEN N'فعال'
	ELSE 'غیر فعال'
	END AS [وضعیت],
	FORMAT(C.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	FORMAT(C.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ویرایش]
FROM BUS.Carts C
INNER JOIN BUS.Banks BN ON C.BankID = BN.ID
INNER JOIN BUS.Customers CS ON C.CustomerID = CS.ID
INNER JOIN BUS.Blances B ON B.CartID = C.ID
WHERE C.IsDeleted = 0 AND B.IsActive = 1
ORDER BY C.ID DESC 
{paging}
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValuesParent()
        {
            return Context.Carts.Where(x => x.ParentID == null && x.CartType == Account.Domain.Library.Enums.CartType.Main).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesAllParentCart()
        {
            return Context.Carts.Where(x => x.ParentID == null && !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesAllCart()
        {
            return Context.Carts.Where(x => !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesCartByBankId(long Id)
        {
            return Context.Carts.Where(x => x.BankID == Id && !x.IsDeleted && x.IsActive).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesChild(long Id)
        {
            return Context.Carts.Where(x => x.ParentID == Id || x.ID == Id).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValueByUser(long Id)
        {
            return Context.Carts.Where(x => x.CustomerID == Id).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return Context.Carts.Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }

        public CartDTO GetCartByAccountNumber(string number)
        {
            throw new NotImplementedException();
        }

        public bool ValidBankBlance(long cartId, double cash)
        {
            throw new NotImplementedException();
        }
    }
}

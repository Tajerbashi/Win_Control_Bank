using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Enums;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class BlanceRepository : GenericRepository<Blance, BlanceDTO, BlanceView>, IBlanceRepository
    {
        public BlanceRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public string GetCount()
        {
            return (@"
SELECT   
	COUNT(B.ID)
FROM
	BUS.Banks B
	INNER JOIN BUS.Carts CT ON B.ID = CT.BankID 
	INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID 
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID
WHERE        
	(B.IsDeleted = 0)
AND (CT.IsDeleted = 0) 
AND (CS.IsDeleted = 0) 
AND (BL.IsDeleted = 0)
");
        }
        public double? GetBlanceCartById(long Id)
        {
            var result = Context.Blances.Where(x => x.CartID == Id && x.BlanceType == BlanceType.Banking).OrderByDescending(x => x.ID).FirstOrDefault();
            return result?.NewBlanceCash;
        }
        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }
        public string ShowAllByCartId(long Id, string paging)
        {
            return ($@"
SELECT   
	BL.ID AS آیدی, 
	B.BankName AS [نام بانک], 
	CT.AccountNumber AS [شماره کارت], 
	CS.FullName AS [مالک حساب], 
	(
		CASE BL.BlanceType
			WHEN 1 THEN N'نقدی'
			WHEN 2 THEN N'بانکی'
			ELSE N'نامعلوم'
		END
	) AS [نوع حساب], 
	(
		CASE BL.TransactionType
			WHEN 1 THEN N'واریزی'
			WHEN 2 THEN N'برداشت'
			ELSE N''
			END
	) AS [نوع تراکنش],
	FORMAT(CAST(BL.OldBlanceCash as bigint),'###,###,###') AS [موجودی قبلی],
	FORMAT(CAST(BL.TransactionCash as bigint),'###,###,###') AS [مبلغ تراکنش], 
	FORMAT(CAST(BL.NewBlanceCash as bigint),'###,###,###') AS [موجودی جدید],
    BL.Description AS [توضیحات]
FROM
	BUS.Banks B
	INNER JOIN BUS.Carts CT ON B.ID = CT.BankID AND CT.ID = {Id}
	INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID 
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID
WHERE        
	(B.IsDeleted = 0)
AND (CT.IsDeleted = 0) 
AND (CS.IsDeleted = 0) 
AND (BL.IsDeleted = 0)
ORDER BY BL.ID DESC
{paging}");
        }
        public string Show50LastTransactions(string paging)
        {
            return ($@"
SELECT   
	BL.ID AS آیدی, 
	B.BankName AS [نام بانک], 
	CT.AccountNumber AS [شماره کارت], 
	CS.FullName AS [مالک حساب], 
	(
		CASE BL.BlanceType
			WHEN 1 THEN N'نقدی'
			WHEN 2 THEN N'بانکی'
			ELSE N'نامعلوم'
		END
	) AS [نوع حساب], 
	(
		CASE BL.TransactionType
			WHEN 1 THEN N'واریزی'
			WHEN 2 THEN N'برداشت'
			ELSE N''
			END
	) AS [نوع تراکنش],
	FORMAT(CAST(BL.OldBlanceCash as bigint),'###,###,###') AS [موجودی قبلی],
	FORMAT(CAST(BL.TransactionCash as bigint),'###,###,###') AS [مبلغ تراکنش], 
	FORMAT(CAST(BL.NewBlanceCash as bigint),'###,###,###') AS [موجودی جدید],
    BL.Description AS [توضیحات]

FROM
	BUS.Banks B
	INNER JOIN BUS.Carts CT ON B.ID = CT.BankID 
	INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID 
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID
WHERE        
	(B.IsDeleted = 0)
AND (B.BankName NOT LIKE N'%:%')
AND (CT.IsDeleted = 0) 
AND (CS.IsDeleted = 0) 
AND (BL.IsDeleted = 0)
ORDER BY BL.ID DESC
{paging}
");
        }

        public IEnumerable<KeyValue<byte>> TitleValueBlanceType()
        {
            return new List<KeyValue<byte>>()
            {
                new KeyValue<byte> { Value = 1 ,Key = "نقدی"},
                new KeyValue<byte> { Value = 2 ,Key = "بانکی"},
            };
        }
        public IEnumerable<KeyValue<byte>> TitleValueTransactionType()
        {
            return new List<KeyValue<byte>>()
            {
                new KeyValue<byte> { Value = 1 ,Key = "واریزی"},
                new KeyValue<byte> { Value = 2 ,Key = "برداشت"},
            };
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return new List<KeyValue<long>>()
            {
                new KeyValue<long> { Value = 1 ,Key = "برداشت از حساب"},
                new KeyValue<long> { Value = 2 ,Key = "کارت به کارت"},
                new KeyValue<long> { Value = 3 ,Key = "واریزی به حساب"},
            };
        }

        public void DisActiveLastBlanceOfCartById(long cartId)
        {
            var lastBlance  = Context.Blances.Where(x => x.CartID  == cartId).OrderByDescending(x => x.ID).FirstOrDefault();
            lastBlance.IsActive = false;
            base.Save();
        }

        public IEnumerable<KeyValue<long>> TitleValueTransactionType(int cartId)
        {
            throw new NotImplementedException();
        }

        public string ShowAllCashableBlances(string paging)
        {
            return ($@"
SELECT   
	BL.ID AS آیدی, 
	B.BankName AS [نام بانک], 
	CT.AccountNumber AS [شماره کارت], 
	CS.FullName AS [مالک حساب], 
	(
		CASE BL.BlanceType
			WHEN 1 THEN N'نقدی'
			WHEN 2 THEN N'بانکی'
			ELSE N'نامعلوم'
		END
	) AS [نوع حساب], 
	(
		CASE BL.TransactionType
			WHEN 1 THEN N'واریزی'
			WHEN 2 THEN N'برداشت'
			ELSE N''
			END
	) AS [نوع تراکنش],
	FORMAT(CAST(BL.OldBlanceCash as bigint),'###,###,###') AS [موجودی قبلی],
	FORMAT(CAST(BL.TransactionCash as bigint),'###,###,###') AS [مبلغ تراکنش], 
	FORMAT(CAST(BL.NewBlanceCash as bigint),'###,###,###') AS [موجودی جدید],
    BL.Description AS [توضیحات]

FROM
	BUS.Banks B
	INNER JOIN BUS.Carts CT ON B.ID = CT.BankID 
	INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID 
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID AND BL.BlanceType = 1
WHERE        
	(B.IsDeleted = 0)
AND (CT.IsDeleted = 0) 
AND (CS.IsDeleted = 0) 
AND (BL.IsDeleted = 0)
ORDER BY BL.ID DESC
{paging}
");
        }

        public string ShowAllByCartIdAndBlanceType(long cartId, byte blanceType, string paging)
        {
            return ($@"
SELECT   
	BL.ID AS آیدی, 
	B.BankName AS [نام بانک], 
	CT.AccountNumber AS [شماره کارت], 
	CS.FullName AS [مالک حساب], 
	(
		CASE BL.BlanceType
			WHEN 1 THEN N'نقدی'
			WHEN 2 THEN N'بانکی'
			ELSE N'نامعلوم'
		END
	) AS [نوع حساب], 
	(
		CASE BL.TransactionType
			WHEN 1 THEN N'واریزی'
			WHEN 2 THEN N'برداشت'
			ELSE N''
			END
	) AS [نوع تراکنش],
	FORMAT(CAST(BL.OldBlanceCash as bigint),'###,###,###') AS [موجودی قبلی],
	FORMAT(CAST(BL.TransactionCash as bigint),'###,###,###') AS [مبلغ تراکنش], 
	FORMAT(CAST(BL.NewBlanceCash as bigint),'###,###,###') AS [موجودی جدید],
    BL.Description AS [توضیحات]
FROM
	BUS.Banks B
	INNER JOIN BUS.Carts CT ON B.ID = CT.BankID AND CT.ID = {cartId}
	INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID 
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID " + (blanceType == 0 ? "" : $@"AND (BL.BlanceType = {blanceType})") + $@"
WHERE        
	(B.IsDeleted = 0)
AND (CT.IsDeleted = 0) 
AND (CS.IsDeleted = 0) 
AND (BL.IsDeleted = 0)
ORDER BY BL.ID DESC
{paging}");
        }
    }
}

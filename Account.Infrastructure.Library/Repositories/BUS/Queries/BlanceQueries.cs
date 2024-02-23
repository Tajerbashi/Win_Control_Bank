using System;

namespace Account.Infrastructure.Library.Repositories.BUS.Queries
{
    public static class BlanceQueries
    {
        public static string Show50LastBankingTransactions(string paging)
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
	INNER JOIN BUS.Blances BL ON CT.ID = BL.CartID AND BL.BlanceType = 2
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
   
        public static string ShowAllCashableBlances(string paging)
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

        public static string GetCount()
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

        public static string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public static string Search(string value)
        {
            throw new NotImplementedException();
        }

        public static string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public static string ShowCashableTransactionsByCartID(long cartId, string paging)
        {
            throw new NotImplementedException();
        }

        public static string ShowBankingTransactionsByCartID(long cartId, string paging)
        {
            throw new NotImplementedException();
        }

        public static string ShowAllBankingBlances(string paging)
        {
            throw new NotImplementedException();
        }

        public static string Show50LastCashableTransactions(string paging)
        {
            throw new NotImplementedException();
        }
    }

}

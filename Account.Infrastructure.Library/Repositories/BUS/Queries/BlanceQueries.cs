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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
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
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
ORDER BY BL.ID DESC
{paging}
");
        }

        public static string Search(string value)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND ( 
	CT.AccountNumber LIKE N'%'+{value}+'%'  
OR
	CS.FullName LIKE N'%'+{value}+'%' 
OR
	BN.BankName LIKE N'%'+{value}+'%' 
	)
ORDER BY BL.ID DESC
");
        }

        public static string ShowFromTo(string from, string to)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND BL.CreateDate BETWEEN {from} AND {to}
ORDER BY BL.ID DESC
");
        }

        public static string ShowCashableTransactionsByCartID(long cartId, string paging)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0 AND CT.ID = {cartId}
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND BL.BlanceType = 1
ORDER BY BL.ID DESC
{paging}
");
        }

        public static string ShowBankingTransactionsByCartID(long cartId, string paging)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0 AND CT.ID = {cartId}
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND BL.BlanceType = 2
ORDER BY BL.ID DESC
{paging}
");
        }

        public static string ShowAllBankingBlances(string paging)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0 
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND BL.BlanceType = 2
ORDER BY BL.ID DESC
{paging}
");
        }

        public static string Show50LastCashableTransactions(string paging)
        {
            return ($@"
SELECT 
	BL.ID AS آیدی, 
	BN.BankName AS [نام بانک], 
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
	FORMAT(BL.CreateDate,'yyyy-MM-dd HH:mm:ss','fa') AS [تاریخ تراکنش], 
    BL.Description AS [توضیحات]
FROM BUS.Blances BL
INNER JOIN BUS.Carts CT ON BL.CartID = CT.ID AND CT.IsDeleted = 0 
INNER JOIN BUS.Customers CS ON CT.CustomerID = CS.ID AND CS.IsDeleted = 0
INNER JOIN BUS.Banks BN ON CT.BankID = BN.ID AND BN.IsDeleted = 0
WHERE BL.IsDeleted = 0
AND BL.NewBlanceCash > 0
AND BL.BlanceType = 2
ORDER BY BL.ID DESC
{paging}
");
        }
    }

}

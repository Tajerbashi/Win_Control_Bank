using Account.Application.Library.Models.Controls;
using System;
using System.Collections.Generic;

namespace Account.Infrastructure.Library.Repositories.BUS.Queries
{
    public static class SettlemantQueries
    {
        public static string ShowAll(string paging)
        {
            return ($@"
SELECT 
SE.ID AS [#],
SE.TransactionID AS [کلید تراکنش],
BN.BankName [نام بانک],
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
CT.AccountNumber [شماره کارت],
CS.FullName [مالک حساب],
FORMAT(CAST(BL.OldBlanceCash as bigint),'###,###,###') AS [موجودی قبلی],
FORMAT(CAST(BL.TransactionCash as bigint),'###,###,###') AS [مبلغ تراکنش],
FORMAT(CAST(BL.NewBlanceCash as bigint),'###,###,###') AS [موجودی جدید]
,FORMAT([SE].[Date],'yyyy-MM-dd','fa') AS [تاریخ]
FROM BUS.Banks BN
INNER JOIN BUS.Carts CT ON CT.BankID = BN.ID
INNER JOIN BUS.Customers CS ON CS.ID = CT.CustomerID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN [BUS].[Settlemants] SE ON SE.TransactionID = BL.TransactionId
WHERE BN.IsDeleted = 0
ORDER BY SE.ID DESC
{paging}
");
        }

        internal static string GetCount()
        {
            return ($@"
SELECT 
COUNT(SE.ID)
FROM BUS.Banks BN
INNER JOIN BUS.Carts CT ON CT.BankID = BN.ID
INNER JOIN BUS.Customers CS ON CS.ID = CT.CustomerID
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID
INNER JOIN [BUS].[Settlemants] SE ON SE.TransactionID = BL.TransactionId
WHERE BN.IsDeleted = 0
");
        }

        internal static string Search(string value)
        {
            throw new NotImplementedException();
        }

        internal static string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<KeyValue<byte>> TitleValue()
        {
            throw new NotImplementedException();
        }
    }

}

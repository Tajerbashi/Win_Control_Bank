using Account.Domain.Library.Enums;

namespace Account.Infrastructure.Library.Repositories.BUS.Queries
{
    public static class CustomerQueries
    {
        public static string GetCount()
        {
            return (@"
SELECT  COUNT(*)
FROM    BUS.Customers
WHERE   IsDeleted = 0
");
        }
        public static string ShowAll(string paging)
        {
            return ($@"
SELECT       
    CS.ID AS [آیدی], 
    CS.FullName AS [نام کامل], 
    FORMAT(CS.CreateDate,'yyyy-MM-dd','fa') AS [تاریخ ثبت], 
    FORMAT(CS.UpdateDate,'yyyy-MM-dd','fa') AS [آخرین ویرایش],   
    CASE CS.IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS [وضعیت],
    CS.Picture AS [تصویر]
FROM BUS.Customers CS
WHERE CS.IsDeleted = 0
ORDER BY CS.ID DESC 
{paging}
");
        }
        
        public static string ShowAllByCustomerType(CartType cartType, string paging)
        {
            return ($@"
SELECT       
    CS.ID AS [آیدی], 
    CS.FullName AS [نام کامل], 
    FORMAT(CS.CreateDate,'yyyy-MM-dd','fa') AS [تاریخ ثبت], 
    FORMAT(CS.UpdateDate,'yyyy-MM-dd','fa') AS [آخرین ویرایش],  
    CASE CS.IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS [وضعیت],
    CS.Picture AS [تصویر]
FROM BUS.Customers CS
INNER JOIN BUS.Carts CT ON CT.CustomerID = CS.ID AND CT.CartType = {(byte)cartType}
INNER JOIN BUS.Blances BL ON BL.CartID = CT.ID 
WHERE CS.IsDeleted = 0
AND CT.IsDeleted = 0
AND BL.IsDeleted = 0
GROUP BY CS.ID,CS.FullName,CS.CreateDate,CS.UpdateDate,CS.IsActive,CS.Picture
ORDER BY CS.ID DESC 
{paging}
");
        }
    }

}

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
            return (@"
SELECT       
    ID AS [آیدی], 
    FullName AS [نام کامل], 
    FORMAT(CreateDate,'yyyy-mm-dd','fa') AS [تاریخ ثبت], 
    UpdateDate AS [آخرین ویرایش],   
    CASE IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS [وضعیت],
    Picture AS [تصویر]
FROM            BUS.Customers
WHERE IsDeleted = 0
");
        }
        
        public static string ShowAllByCustomerType(CartType cartType, string paging)
        {
            return ($@"");
        }
    }

}

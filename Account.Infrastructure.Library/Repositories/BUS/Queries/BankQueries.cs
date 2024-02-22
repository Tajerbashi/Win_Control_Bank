namespace Account.Infrastructure.Library.Repositories.BUS.Queries
{
    public static class BankQueries
    {
        public static string GetCount()
        {
            return (@$"SELECT  COUNT(*) FROM    BUS.Banks WHERE   (IsDeleted = 0)");
        }
        public static string ShowAll(string paging)
        {
            return (@$"
SELECT        
ID AS آیدی, 
BankName AS [نام بانک], 
FORMAT(CreateDate,'yyyy-mm-dd','fa') AS [تاریخ ثبت], 
UpdateDate AS [تاریخ ویرایش], 
CASE IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS وضعیت
FROM BUS.Banks
WHERE (IsDeleted = 0)
AND BankName NOT LIKE N'%:%'
ORDER BY ID DESC 
{paging}
");
        }
    }
}

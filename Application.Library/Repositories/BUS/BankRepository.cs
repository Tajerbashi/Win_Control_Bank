using AutoMapper;
using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IGenericQueries
    {
        protected BankRepository(IMapper mapper) : base(mapper)
        {
        }

        public string GetCount()
        {
            return (@$"SELECT  COUNT(*) FROM    BUS.Banks WHERE   (IsDeleted = 0)");
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            return (@$"
SELECT        
ID AS آیدی, 
BankName AS [نام بانک], 
FORMAT(CreateDate,'yyyy-mm-dd','fa') AS [تاریخ ثبت], 
UpdateDate AS [تاریخ ویرایش], 
Title AS عنوان, Description AS توضیحات, 
CASE IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS وضعیت
FROM            BUS.Banks
WHERE        (IsDeleted = 0)
ORDER BY ID DESC 
{paging}
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return _context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}

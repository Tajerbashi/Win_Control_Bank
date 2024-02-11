using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Models.Controls;
using Account.Infrastructure.Library.Models.DTOs.BUS;
using Account.Infrastructure.Library.Models.Views.BUS;
using Account.Infrastructure.Library.Patterns;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public abstract class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IGenericQueries
    {
        protected BankRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected BankRepository(ContextDbApplication context)
            : base(context)
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
            return Context.Banks.Select(x => new KeyValue<long>
            {
                Key = x.BankName,
                Value = x.ID
            });
        }
    }
}

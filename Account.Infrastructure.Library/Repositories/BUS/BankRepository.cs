using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Patterns;
using System.Collections.Generic;
using System.Linq;

namespace Account.Application.Library.Repositories.BUS
{
    public class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IBankRepository
    {
        public BankRepository(UnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected BankRepository(ContextDbApplication context) : base(context)
        {
        }

        public BankDTO GetBankByName(string name)
        {
            return null;
        }

        public string GetCount()
        {
            return (@$"SELECT  COUNT(*) FROM    BUS.Banks WHERE   (IsDeleted = 0)");
        }

        public string Search(string value)
        {
            return null;
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
            return null;
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

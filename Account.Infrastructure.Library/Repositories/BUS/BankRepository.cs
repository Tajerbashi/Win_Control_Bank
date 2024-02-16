using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class BankRepository : GenericRepository<Bank, BankDTO, BankView>, IBankRepository
    {
        public BankRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public BankDTO GetBankByName(string name)
        {
            var result = Context.Banks.Where(c => c.BankName.Equals(name.Trim())).FirstOrDefault();
            return Mapper.Map<Bank, BankDTO>(result);
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

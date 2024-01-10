using Domain.Library.Entities.BUS;
using Infrastructure.Library.ApplicationContext.EF;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.Controls;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Patterns;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CustomerRepository : GenericRepository<Customer, CustomerDTO, CustomerView>, IGenericQueries
    {
        protected CustomerRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }

        public string GetCount()
        {
            return (@"
SELECT  COUNT(*)
FROM    BUS.Customers
WHERE   IsDeleted = 0
");
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            return (@"
SELECT       
    ID AS آیدی, 
    FullName AS [نام کامل], 
    FORMAT(CreateDate,'yyyy-mm-dd','fa') AS [تاریخ ثبت], 
    UpdateDate AS [آخرین ویرایش],   
    CASE IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS وضعیت,
    Description AS توضیحات, 
    Title AS عنوان, 
    Picture AS نصویر
FROM            BUS.Customers
WHERE IsDeleted = 0
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return Context.Customers.Select(x => new KeyValue<long>
            {
                Key = x.FullName,
                Value = x.ID
            }).OrderByDescending(x => x.Key);
        }
    }
}

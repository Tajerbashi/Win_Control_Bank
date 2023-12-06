using Domain.Library.Entities.BUS;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.Views.BUS;

namespace Infrastructure.Library.Repositories.BUS
{
    public abstract class CustomerRepository : GenericRepository<Customer, CustomerDTO, CustomerView>, IGenericQueries
    {
        public string GetCount()
        {
            throw new NotImplementedException();
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            return (@"
SELECT        ID AS آیدی, FullName AS [نام کامل], [Key] AS [کلید اختصاصی], Guid AS [کد اختصاصی], CreateDate AS [تاریخ ثبت], UpdateDate AS [آخرین ویرایش], IsActive AS وضعیت, Description AS توضیحات, Title AS عنوان, Picture AS نصویر
FROM            BUS.Customers
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }
    }
}

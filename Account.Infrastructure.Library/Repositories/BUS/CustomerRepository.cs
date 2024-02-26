using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Enums;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Repositories.BUS.Queries;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class CustomerRepository : GenericRepository<Customer, CustomerDTO, CustomerView>, ICustomerRepository
    {
        public CustomerRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public string GetCount()
        {
            return CustomerQueries.GetCount();
        }

        public CustomerDTO GetCustomerByName(string name)
        {
            var customer = Context.Customers.Where(x => x.FullName.Equals(name) && !x.IsDeleted).FirstOrDefault();
            return Mapper.Map<Customer, CustomerDTO>(customer);
        }

        public string Search(string value)
        {
            return ("");
        }

        public string ShowAll(string paging)
        {
            return CustomerQueries.ShowAll(paging);
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> CustomerTitleValue()
        {
            return Context.Customers.Include(c => c.Carts).Where(x => !x.IsDeleted && x.Carts.Any(c => c.CartType == CartType.Main)).Select(x => new KeyValue<long>
            {
                Key = x.FullName,
                Value = x.ID
            }).OrderByDescending(x => x.Key);
        }

        public string ShowAllByCustomerType(CartType cartType, string paging)
        {
            return CustomerQueries.ShowAllByCustomerType(cartType,paging);
        }
    }
}

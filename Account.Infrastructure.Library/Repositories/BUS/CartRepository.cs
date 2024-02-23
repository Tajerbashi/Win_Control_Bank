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
    public class CartRepository : GenericRepository<Cart, CartDTO, CartView>, ICartRepository
    {
        public CartRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public string GetCount()
        {
            return CartQueries.GetCount();
        }

        public string Search(string value)
        {
            return CartQueries.Search(value);
        }
        public string SearchByCartId(long Id, string paging)
        {
            return CartQueries.SearchByCartId(Id, paging);
        }

        public string ShowAll(string paging)
        {
            return CartQueries.ShowAll(paging);
        }

        public string ShowFromTo(string from, string to)
        {
            return CartQueries.ShowFromTo(from, to);
        }

        public IEnumerable<KeyValue<long>> TitleValuesCashableParent()
        {
            return Context.Carts.Where(x => x.ParentID == null && !x.ShabaAccountNumber.Contains("Cashable") && x.CartType == Account.Domain.Library.Enums.CartType.Main).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesBankingParent()
        {
            return Context.Carts.Where(x => x.ParentID == null && !x.ShabaAccountNumber.Contains("Cashable") && x.CartType == Account.Domain.Library.Enums.CartType.Main).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesAllParentCart()
        {
            return Context.Carts.Include(b => b.Bank).Where(x => x.ParentID == null && !x.Bank.BankName.Contains(":") && !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesAllCart()
        {
            return Context.Carts.Include(c => c.Bank).Where(x => !x.IsDeleted && !x.Bank.BankName.Contains(":")).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesCartByBankId(long Id)
        {
            return Context.Carts.Where(x => x.BankID == Id && !x.IsDeleted && x.IsActive).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValuesChild(long Id)
        {
            return Context.Carts.Where(x => x.ParentID == Id || x.ID == Id).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }

        public IEnumerable<KeyValue<long>> TitleValuesMainCarts(long Id)
        {
            return Context.Carts.Where(x => x.CustomerID == Id && !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }
        public IEnumerable<KeyValue<long>> TitleValueByUser(long Id)
        {
            return Context.Carts.Where(x => x.CustomerID == Id && !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = ($@"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value = x.ID
            });
        }


        public CartDTO GetCartByAccountNumber(string number)
        {
            var entity = Context.Carts.Where(x => x.AccountNumber.Equals(number) && !x.IsDeleted).FirstOrDefault();
            return Mapper.Map<CartDTO>(entity);
        }

        public bool ValidBankBlance(long cartId, double cash)
        {
            var lastBlance = Context.Blances.Where(x => x.CartID == cartId).OrderByDescending(x => x.ID).FirstOrDefault().NewBlanceCash;
            if (lastBlance >= cash)
            {
                return true;
            }
            return false;
        }

        public long GetCashableCartByCustomerId(long CustomerId)
        {
            var CartId  = Context.Carts.Include(ct => ct.Blances)
                .Where(ct => ct.CustomerID == CustomerId && ct.Blances.Any(bl => bl.BlanceType == Domain.Library.Enums.BlanceType.Cashable)).FirstOrDefault();
            return CartId == null ? 0 : CartId.ID;
        }

        public IEnumerable<KeyValue<long>> TitleValuesCartsByCartIdAboutCustomer(long Id)
        {
            var result =  Context.Carts
                .Include(cs => cs.Customer)
                .Include(cs => cs.Bank)
                .Where(ct => ct.ID == Id)
                .Select(ct => new KeyValue<long>
                {
                    Key=$"{ct.Bank.BankName} - {ct.Customer.FullName} - {ct.AccountNumber}",
                    Value=ct.ID
                });
            return result;
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            var result = Context.Carts.Where(x => x.IsActive && !x.IsDeleted).Select(x => new KeyValue<byte>
            {
                Key="",
                Value=(byte)x.ID
            }).ToList();
            return result;
        }

        public IEnumerable<KeyValue<long>> TitleValueByUserID(long customerID)
        {
            var result = Context.Carts.Include(ct => ct.Customer).Include(bn => bn.Bank).Where(x => x.CustomerID == customerID && x.IsActive && !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key=($"{x.Bank.BankName} - {x.Customer.FullName} - {x.AccountNumber}"),
                Value= x.ID
            }).ToList();
            return result;
        }

        public bool ValidBlancForTransaction(long cartId, double cash)
        {
            var blance = Context.Blances.Where(x => x.CartID == cartId).OrderByDescending(x => x.ID).FirstOrDefault();
            if (blance.NewBlanceCash >= cash)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<KeyValue<CartType>> TitleValuesDegreeCart()
        {
            return new List<KeyValue<CartType>>
            {
                new KeyValue<CartType>{ Key="مشترک",Value=CartType.Main },
                new KeyValue<CartType>{ Key="فرعی",Value=CartType.Custome },
            };
        }
    }
}

using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Repositories.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using Account.Infrastructure.Library.Repositories.BUS.Queries;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Infrastructure.Library.Repositories.BUS
{
    public class BlanceRepository : GenericRepository<Blance, BlanceDTO, BlanceView>, IBlanceRepository
    {
        public BlanceRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

        public string GetCount()
        {
            return BlanceQueries.GetCount();
        }
        public IEnumerable<KeyValue<byte>> TitleValueBlanceType()
        {
            return new List<KeyValue<byte>>()
            {
                new KeyValue<byte> { Value = 1 ,Key = "نقدی"},
                new KeyValue<byte> { Value = 2 ,Key = "بانکی"},
            };
        }
        public IEnumerable<KeyValue<byte>> TitleValueTransactionType()
        {
            return new List<KeyValue<byte>>()
            {
                new KeyValue<byte> { Value = 1 ,Key = "واریزی"},
                new KeyValue<byte> { Value = 2 ,Key = "برداشت"},
            };
        }

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            return new List<KeyValue<byte>>()
            {
                new KeyValue<byte> { Value = 1 ,Key = "خرید از کارت"},
                new KeyValue<byte> { Value = 1 ,Key = "خرید شارژ"},
                new KeyValue<byte> { Value = 2 ,Key = "خرید نقدی"},
                new KeyValue<byte> { Value = 3 ,Key = "کارت به کارت"},
                new KeyValue<byte> { Value = 4 ,Key = "برداشت نقدی از کارت واریز به حساب نقدی"},
            };
        }
        public string ShowAllCashableBlances(string paging)
        {
            return BlanceQueries.ShowAllCashableBlances(paging);
        }

        public string Show50LastCashableTransactions(string paging)
        {
            return BlanceQueries.Show50LastCashableTransactions(paging);
        }

        public double? GetCashableBlanceByCartId(long cartId)
        {
            var cart = Context.Blances.Where(x => x.CartID == cartId && !x.IsDeleted && x.BlanceType == Domain.Library.Enums.BlanceType.Cashable && x.IsActive).OrderByDescending(x => x.ID).FirstOrDefault();
            if (cart == null)
            {
                return 0;
            }
            return cart.NewBlanceCash;
        }

        public void DisActiveLastCashableBlanceOfCartById(long cartId)
        {
            var cart = Context.Blances.Where(x => x.CartID == cartId && !x.IsDeleted && x.BlanceType == Domain.Library.Enums.BlanceType.Cashable && x.IsActive)
                .OrderByDescending(x => x.ID).FirstOrDefault();
            if (cart == null)
            {
                return;
            }
            cart.IsActive = false;
            base.Save();
        }

        public string Show50LastBankingTransactions(string paging)
        {
            return BlanceQueries.Show50LastBankingTransactions(paging);
        }

        public string ShowAllBankingBlances(string paging)
        {
            return BlanceQueries.ShowAllBankingBlances(paging);
        }

        public double? GetBankingBlanceByCartId(long cartId)
        {
            var blance = Context.Blances.Where(x => x.CartID == cartId && x.BlanceType == Domain.Library.Enums.BlanceType.Banking && !x.IsDeleted && x.IsActive).OrderByDescending(x => x.ID).FirstOrDefault();
            if (blance is null)
            {
                return 0;
            }
            return blance.NewBlanceCash;
        }

        public void DisActiveLastBankingBlanceOfCartById(long cartId)
        {
            var blance = Context.Blances.Where(x => x.CartID == cartId && !x.IsDeleted).OrderByDescending(x => x.ID).FirstOrDefault();
            blance.UpdateDate = DateTime.Now;
            blance.IsActive = false;
            Context.SaveChanges();
        }

        public string ShowAll(string paging)
        {
            return BlanceQueries.ShowAll(paging);
        }

        public string Search(string value)
        {
            return BlanceQueries.Search(value);
        }

        public string ShowFromTo(string from, string to)
        {
            return BlanceQueries.ShowFromTo(from, to);
        }

        public string ShowCashableTransactionsByCartID(long cartId, string paging)
        {
            return BlanceQueries.ShowCashableTransactionsByCartID(cartId, paging);
        }

        public string ShowBankingTransactionsByCartID(long cartId, string paging)
        {
            return BlanceQueries.ShowBankingTransactionsByCartID(cartId, paging);
        }
    }
}

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
            throw new NotImplementedException();
        }

        public double? GetCashableBlanceByCartId(long cartId)
        {
            throw new NotImplementedException();
        }

        public void DisActiveLastCashableBlanceOfCartById(long cartId)
        {
            throw new NotImplementedException();
        }

        public string Show50LastBankingTransactions(string paging)
        {
            return BlanceQueries.Show50LastBankingTransactions(paging);
        }

        public string ShowAllBankingBlances(string paging)
        {
            throw new NotImplementedException();
        }

        public double? GetBankingBlanceByCartId(long cartId)
        {
            throw new NotImplementedException();
        }

        public void DisActiveLastBankingBlanceOfCartById(long cartId)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public string ShowCashableTransactionsByCartID(long cartId, string paging)
        {
            throw new NotImplementedException();
        }

        public string ShowBankingTransactionsByCartID(long cartId, string paging)
        {
            throw new NotImplementedException();
        }
    }
}

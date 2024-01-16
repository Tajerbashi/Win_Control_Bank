using AutoMapper;
using Domain.Library.Entities.BUS;
using Domain.Library.Entities.SEC;
using Domain.Library.Entities.WEB;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.DTOs.WEB;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Models.Views.SEC;
using Infrastructure.Library.Models.Views.WEB;

namespace Infrastructure.Library.ApplicationContext.AutoMapper
{
    public class MapperProfiler : Profile
    {
        public override string ProfileName => base.ProfileName;
        public MapperProfiler()
        {

            #region SEC
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserView>().ReverseMap();
            #endregion

            #region BUS
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Customer, CustomerView>().ReverseMap();

            CreateMap<Bank, BankDTO>().ReverseMap();
            CreateMap<Bank, BankView>().ReverseMap();

            CreateMap<Cart, CartDTO>().ReverseMap();
            CreateMap<Cart, CartView>().ReverseMap();

            CreateMap<CartHistory, CartHistoryDTO>().ReverseMap();
            CreateMap<CartHistory, CartHistoryView>().ReverseMap();

            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Transaction, TransactionView>().ReverseMap();

            CreateMap<Blance, BlanceDTO>().ReverseMap();
            CreateMap<Blance, BlanceView>().ReverseMap();
            #endregion

            #region LOG
            #endregion

            #region RPT
            #endregion

            #region WEB
            CreateMap<WebService, WebServiceDTO>().ReverseMap();
            CreateMap<WebService, WebServiceView>().ReverseMap();
            #endregion

            #region CNT
            #endregion
        }
    }
}

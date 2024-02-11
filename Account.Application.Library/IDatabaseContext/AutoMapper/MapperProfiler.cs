using AutoMapper;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Entities.SEC;
using Account.Domain.Library.Entities.WEB;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.DTOs.SEC;
using Account.Application.Library.Models.DTOs.WEB;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Models.Views.SEC;
using Account.Application.Library.Models.Views.WEB;

namespace Account.Applicatino.Library.IDatabaseContext.AutoMapper
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

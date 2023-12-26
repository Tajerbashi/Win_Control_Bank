using AutoMapper;
using Domain.Library.Entities.BUS;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.Models.DTOs.BUS;
using Infrastructure.Library.Models.DTOs.SEC;
using Infrastructure.Library.Models.Views.BUS;
using Infrastructure.Library.Models.Views.SEC;

namespace Infrastructure.Library.ApplicationContext.AutoMapper
{
    public class MapperProfiler : Profile
    {
        public override string ProfileName => base.ProfileName;
        public MapperProfiler()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserView>().ReverseMap();


            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Customer, CustomerView>().ReverseMap();

            CreateMap<Bank, BankDTO>().ReverseMap();
            CreateMap<Bank, BankView>().ReverseMap();

            CreateMap<Cart, CartDTO>().ReverseMap();
            CreateMap<Cart, CartView>().ReverseMap();

            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Transaction, TransactionView>().ReverseMap();

            CreateMap<Blance, BlanceDTO>().ReverseMap();
            CreateMap<Blance, BlanceView>().ReverseMap();

        }
    }
}

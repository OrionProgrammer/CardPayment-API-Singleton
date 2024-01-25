namespace CardPayment.API.Helpers;

using AutoMapper;
using CardPayment.Domain;
using CardPayment.Model;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<CreditCard, CreditCardModel>().ReverseMap();
        CreateMap<CreditCard, CreditCardModel>();

        CreateMap<Transaction, TransactionModel>().ReverseMap();
        CreateMap<Transaction, TransactionModel>();
    }
}

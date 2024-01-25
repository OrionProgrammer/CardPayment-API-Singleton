using CardPayment.Domain;
using CardPayment.Model;

namespace CardPayment.API.Business_Rules;

public interface ICardSecurity
{
    bool IsCardValid(CreditCard creditCard);
    bool IsFundsAvailable(string cardNumber, decimal amount);
    Task<Guid> Authenticate(AuthenticateModel authenticateModel);
}

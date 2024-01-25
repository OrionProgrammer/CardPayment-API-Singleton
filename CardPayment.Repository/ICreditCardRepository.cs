
using CardPayment.Domain;
using CardPayment.Repository.Helpers;

namespace CardPayment.Repository;

public interface ICreditCardRepository: IGenericRepository<CreditCard>
{
    Task<(string, decimal)> GetBalance(string creditCardNumber, string pinCode);
    Task<bool> GetValidCard(CreditCard creditCard);
    Task<bool> CheckFundsAvailable(string cardNumber, decimal amount);
    Task<CreditCard> GetCardByCardNumber(string cardNumber);
    Task<Guid> GetCardIdByCardNumberPinCode(string cardNumber, string pinCode);
}


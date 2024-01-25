namespace CardPayment.Repository.Helpers;

public interface IUnitOfWork
{
    ICreditCardRepository CreditCardRepository{ get; }
    ITransactionRepository TransactionRepository { get; }

    Task<int> Complete();

}

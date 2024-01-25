
using CardPayment.Domain;
using CardPayment.Repository.Helpers;

namespace CardPayment.Repository;

public interface ITransactionRepository: IGenericRepository<Transaction>
{
}


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CardPayment.Domain;
using CardPayment.Repository;
using CardPayment.Repository.Helpers;

namespace CardPayment.Repository;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
    public TransactionRepository(DataContext context) : base(context) { }

}

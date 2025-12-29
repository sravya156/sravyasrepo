using System;
using NatureHub2.Models;

namespace NatureHub2.Repos
{
    public class TransactionRepo : Repository<Transaction>, ITransactionRepo
    {
        public TransactionRepo(HubDb2Context context) : base(context) { }
    }

}

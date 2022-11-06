using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface ITransactionService
    {
        public ITransaction MoneyStart(Guid IDFrom, Guid IDTo, decimal startAmount, string description);
        public decimal GetAmount(Guid ownerID);
        public string GetAllTransactions(Guid ownerID);

    }
}

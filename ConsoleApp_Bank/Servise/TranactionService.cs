using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class TranactionService
    {

        public ITransaction MoneyStart(Guid IDFrom, Guid IDTo, decimal startAmount, string description)
        {
            ITransaction transaction = new Transaction(IDFrom, IDTo, startAmount, description);
            return transaction;
        }

        public ITransaction MoneyTransfer(Guid IDFrom, Guid IDTo, decimal startAmount, string description)
        {

        }

        private decimal GetAmount(Guid playerID, decimal amount)
        {

        }

    }
}

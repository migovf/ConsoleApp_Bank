using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp_Bank
{
    public class TranactionService : ITransactionService
    {

        public ITransaction MoneyStart(Guid IDFrom, Guid IDTo, decimal startAmount, string description)
        {
            ITransaction transaction = new Transaction(IDFrom, IDTo, startAmount, description);
            return transaction;
        }

        public decimal GetAmount(Guid ownerID)
        {
            decimal amountRes = 0;
            foreach (var res in IVirtualRepository.Accounts)
            {
                if (res.OwnerID == ownerID)
                {
                    foreach (var transaction in res.Transactions)
                    {
                        amountRes += transaction.Amount;
                    }
                    break;
                }
            }

            return amountRes;
        }

        public string GetAllTransactions(Guid ownerID)
        {
            string res = string.Empty;
            decimal balance = 0;
            IAccountService IAccSer = new AccountService();

            res += $"{new string('=', 50)}\n";
            res += $"{new string('=', 20)}";
            res += $"Owner Name: [{IAccSer.GetOwnerName(ownerID)}]\n";
            foreach (var account in IVirtualRepository.Accounts)
            {
                if (account.OwnerID == ownerID)
                {
                    foreach (var transaction in account.Transactions)
                    {
                        res += $"Id: {transaction.ID}\n";
                        res += $"From: {IAccSer.GetOwnerName(transaction.FromID)}\n";
                        res += $"To: {IAccSer.GetOwnerName(transaction.ToID)} \n";
                        res += $"Amount: {transaction.Amount}\n";
                        res += $"\n";

                    }
                }

            }
            res += $"Total Balance: {GetAmount(ownerID)}";
            res += $"{new string('=', 50)}\n";


            return res;
        }


    }
}

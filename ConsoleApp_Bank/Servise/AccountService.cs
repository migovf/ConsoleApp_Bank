using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class AccountService : IAccountService
    {
        public IAccount CreateAccount(Guid ownerID, decimal startAmount)
        {
            IAccount account = new Account(ownerID);
            IVirtualRepository.Accounts.Add(account);
            return account;
        }

        public decimal GetMoneyAmount(Guid ownerID)
        {
            ITransactionService transactionService = new TranactionService();
            return transactionService.GetAmount(ownerID);
        }

        public void MoneyTransfer(Guid fromID, Guid toID, decimal amount)
        {
            foreach (var account in IVirtualRepository.Accounts)
            {
                if (account.OwnerID == fromID)
                    account.Transactions.Add(new Transaction(fromID, toID, amount * -1));
            }
            foreach (var account in IVirtualRepository.Accounts)
            {
                if (account.OwnerID == toID)
                    account.Transactions.Add(new Transaction(fromID, toID, amount));
            }
        }

        public string GetAllTransactions(Guid ownerID)
        {
            ITransactionService transactionService = new TranactionService();
            return transactionService.GetAllTransactions(ownerID);
        }

        public string GetOwnerName(Guid ownerID)
        {
            string name = string.Empty;
            foreach (IPlayer player in IVirtualRepository.Players)
            {
                if (player.PlayerID == ownerID)
                {
                    name = player.Name;
                    break;
                }
            }

            return name;
        }

        public IAccount? GetAccount(Guid accountID)
        {
            IAccount account = null;
            foreach (var target in IVirtualRepository.Accounts)
            {
                if (target.ID == accountID)
                    account = target;
            }
            return account;
        }


    }
}

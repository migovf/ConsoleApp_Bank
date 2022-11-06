using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class BankService : IBankService
    {

        public void CreatePlayer(string name, int age, decimal startAmount)
        {
            IPlayer player = new Player(name, age);
            IVirtualRepository.Players.Add(player);

            IAccount account = new Account(player.PlayerID, startAmount);
            IVirtualRepository.Accounts.Add(account);
        }

        public decimal GetMoneyAmount(Guid ownerID)
        {
            IAccountService accountService = new AccountService();
            decimal amount = accountService.GetMoneyAmount(ownerID);
            return amount;
        }

        public bool IsEnoughMoney(Guid ownerID, decimal amountFoTransaction)
        {
            if (GetMoneyAmount(ownerID) >= amountFoTransaction)
                return true;
            else
                return false;
        }

        public void MoneyTransfer(Guid fromID, Guid toID, decimal amount)
        {
            if (IsEnoughMoney(fromID, amount))
            {
                IAccountService accountService = new AccountService();
                accountService.MoneyTransfer(fromID, toID, amount);
            }
        }

        public string GetListTransactions(Guid ownerID)
        {
            IAccountService accountService = new AccountService();
            return accountService.GetAllTransactions(ownerID);
        }


    }
}

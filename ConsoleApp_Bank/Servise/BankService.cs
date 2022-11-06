using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class BankService : IBankService
    {

        public IPlayer CreatePlayer(string name, int age, decimal startAmount)
        {
            IPlayer player = new Player(name, age);
            IVirtualRepository.Players.Add(player);

            IAccount account = new Account(player.PlayerID, startAmount);
            IVirtualRepository.Accounts.Add(account);
            return player;
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

        public string GetAllTransactions(Guid ownerID)
        {
            IAccountService accountService = new AccountService();
            return accountService.GetAllTransactions(ownerID);
        }


    }
}

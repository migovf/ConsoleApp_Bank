using ConsoleApp_Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface IAccountService
    {

        public IAccount CreateAccount(Guid ownerID, decimal startAmount);
        public string GetAllTransactions(Guid ownerID);
        public decimal GetMoneyAmount(Guid accountID);
        public void MoneyTransfer(Guid fromID, Guid toID, decimal amount);
        public string GetOwnerName(Guid ownerID);

        public IAccount? GetAccount(Guid accountID);

    }
}

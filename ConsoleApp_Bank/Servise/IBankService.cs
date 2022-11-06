using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface IBankService
    {

        public void CreatePlayer(string name, int age, decimal startAmount);
        public decimal GetMoneyAmount(Guid ownerID);
        public bool IsEnoughMoney(Guid ownerID, decimal amountFoTransaction);
        public void MoneyTransfer(Guid fromID, Guid toID, decimal amount);
        public string GetListTransactions(Guid ownerID);
    }
}

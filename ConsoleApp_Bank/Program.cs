using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class Program
    {

        static void Main()
        {
            IBankService bankService = new BankService();

            IPlayer playerBank = bankService.CreateBank();

            IPlayer playerOne = bankService.CreatePlayer("Evgeniy", 24, 18000);
            IPlayer playerTwo = bankService.CreatePlayer("Valeriy", 38, 1000);
            IPlayer playerThree = bankService.CreatePlayer("Vyacheslav", 16, 3000);


            bankService.MoneyTransfer(playerBank.PlayerID, playerOne.PlayerID, 50000);
            bankService.MoneyTransfer(playerBank.PlayerID, playerTwo.PlayerID, 10000);


            Console.WriteLine(bankService.GetAllTransactions(playerOne.PlayerID));
            Console.WriteLine();
            Console.WriteLine(bankService.GetAllTransactions(playerTwo.PlayerID));
            Console.WriteLine();
            Console.WriteLine(bankService.GetAllTransactions(playerThree.PlayerID));


        }

    }
}

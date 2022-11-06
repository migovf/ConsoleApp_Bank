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
            IPlayer bank = bankService.CreateBank();

            IPlayer playerOne = bankService.CreatePlayer("Victor", 24);
            IPlayer playerTwo = bankService.CreatePlayer("Alina", 38);
            IPlayer playerThree = bankService.CreatePlayer("Sergey", 16);


            bankService.MoneyTransfer(bank.PlayerID, playerOne.PlayerID, 50000);
            bankService.MoneyTransfer(bank.PlayerID, playerTwo.PlayerID, 10000);
            bankService.MoneyTransfer(bank.PlayerID, playerThree.PlayerID, 80000);



            Console.WriteLine(bankService.GetAllTransactions(playerOne.PlayerID));
            Console.WriteLine();
            Console.WriteLine(bankService.GetAllTransactions(playerTwo.PlayerID));
            Console.WriteLine();
            Console.WriteLine(bankService.GetAllTransactions(playerThree.PlayerID));
            Console.WriteLine(  );
            Console.WriteLine(bankService.GetAllTransactions(bank.PlayerID));

        }

    }
}

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

            List<ITransaction> transactions = new List<ITransaction>();
            transactions.Add(new Transaction(Guid.NewGuid(), Guid.NewGuid(), 5000, "Start Amount"));


            string result = PrintInfoTransaction(transactions[0]);

            Console.WriteLine(result);
        }

        private static string PrintInfoTransaction(ITransaction transaction)
        {
            
            return $"ID: {transaction.ID}\nFromID: {transaction.FromID}, ToID: {transaction.ToID}, Amount: {transaction.Amount}";
        }
    }
}

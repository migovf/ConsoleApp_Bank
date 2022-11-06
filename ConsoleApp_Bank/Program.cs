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



        }

        private static string PrintInfoTransaction(ITransaction transaction)
        {
            
            return $"ID: {transaction.ID}\nFromID: {transaction.FromID}, ToID: {transaction.ToID}, Amount: {transaction.Amount}";
        }
    }
}

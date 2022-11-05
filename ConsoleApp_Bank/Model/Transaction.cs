using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class Transaction : ITransaction
    {
        public Guid ID { get; set; }
        public Guid FromID { get; set; }
        public Guid ToID { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Transaction() { }
        public Transaction(Guid from, Guid to, decimal amount, string description = "")
        {
            ID = Guid.NewGuid();
            FromID = from;
            ToID = to;
            Amount = amount;
            Description = description;
        }

    }
}

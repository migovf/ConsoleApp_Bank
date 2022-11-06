using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class Account : IAccount
    {
        public Guid ID { get; set; }
        public Guid OwnerID { get; }
        public List<ITransaction> Transactions { get; set; }
        public Account(Guid ownerID) 
        {
            ID = Guid.NewGuid();    
            OwnerID = ownerID;
            Transactions = new List<ITransaction>();
            //Transactions.Add(new Transaction() 
            //{
            //    ID = Guid.NewGuid(),
            //    FromID = Guid.NewGuid(),
            //    ToID = ownerID,
            //    Amount = startAmount
            //});
        }

    }
}

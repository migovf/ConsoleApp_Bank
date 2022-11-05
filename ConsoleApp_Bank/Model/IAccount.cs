using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface IAccount
    {

        Guid ID { get; }
        Guid OwnerID { get; }
        List<ITransaction> Transactions { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface ITransaction
    {
        Guid ID { get; set; }
        Guid FromID { get; set; }
        Guid ToID { get; set; }
        decimal Amount { get; set; }
        string Description { get; set; }
    }
}

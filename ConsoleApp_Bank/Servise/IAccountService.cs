using ConsoleApp_Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Banks
{
    public interface IAccountService
    {
        IAccount CreateAccount(decimal startAmount);
        decimal GetAmount(Guid accountID);
    }
}

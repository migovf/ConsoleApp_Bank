using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface IVirtualRepository
    {

        public static List<IAccount> Accounts { get; set; } = new List<IAccount>();
        public static List<IPlayer> Players { get; set; } = new List<IPlayer> { };

    }
}

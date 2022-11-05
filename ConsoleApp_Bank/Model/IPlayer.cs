using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public interface IPlayer
    {

        Guid PlayerID { get; }
        string Name { get; }
        int Age { get; }
        Guid AccountID { get; set; }

    }
}

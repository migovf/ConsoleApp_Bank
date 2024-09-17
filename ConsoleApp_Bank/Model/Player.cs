using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Bank
{
    public class Player : IPlayer
    {
        public Guid PlayerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid AccountID { get; set; }

        public Player(string name, int age)
        {
            PlayerID = Guid.NewGuid();
            Name = name;
            Age = age;
        }
    }
}

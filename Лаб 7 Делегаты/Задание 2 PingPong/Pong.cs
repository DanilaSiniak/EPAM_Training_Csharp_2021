using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2PingPongDelegati
{
    class Pong
    {
        public delegate void Ud();
        public event Ud Display;
        public void Hit()
        {
            Console.WriteLine("Pong received Ping.");
            if (Display != null)
            System.Threading.Thread.Sleep(1000);
            Display();
        }
    }
}

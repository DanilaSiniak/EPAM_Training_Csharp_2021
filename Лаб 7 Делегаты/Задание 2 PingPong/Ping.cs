using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2PingPongDelegati
{
    class Ping
    {
        public delegate void Ud();
        public event Ud Display;
        public void Hit()
        {
            Console.WriteLine("Ping received Pong.");
            int PingPoints = 0;
            if (Display != null)
            {
                PingPoints++;
            }
     
            System.Threading.Thread.Sleep(1000);
            Display();

        }
    }
}

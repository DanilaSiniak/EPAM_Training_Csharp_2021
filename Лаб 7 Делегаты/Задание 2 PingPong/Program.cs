using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2PingPongDelegati
{
    class Program

    {
        static void Main()
        {

            Ping ping = new Ping();
            Pong pong = new Pong();
            Ping.Ud v = pong.Hit;
            Pong.Ud w = ping.Hit;

            ping.Display += v;
            pong.Display += w;
            ping.Hit();
            Console.ReadKey();
           
        }
    }
}
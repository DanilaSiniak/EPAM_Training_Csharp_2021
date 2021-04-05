using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишите "пинг-понг":
•	2 класса Ping и Pong
•	один уведомляет другого, о том, что "произошёл пинг", другой - о том, что "произошёл понг",
•	одна пара объектов "играют" между собой, другая пара - между собой и т.д.
и выводить на консоль соответсвующие сообщения, что-то вроди такого:
1.	Ping received Pong.
2.	Pong received Ping.
3.	Ping received Pong.
4.	Pong received Ping.
5.	Ping received Pong.
*/
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
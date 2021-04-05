using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace LB1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Action < Func < bool, int>, char, string> lambda = (x, char1, string1) =>
            {
                int tmp = x(true);
                Console.WriteLine(x(true) == 1 ? char1 + string1 : char1 + string1);
       
            };
            Func<bool,int> TT = MyFunc;
            lambda(TT, 'T', " its true");
            lambda(TT, 'F', " its false");
            Console.ReadLine();
        }
        static int MyFunc(bool s)
        {
            return s ? 1 : 0;
        }
    }
}
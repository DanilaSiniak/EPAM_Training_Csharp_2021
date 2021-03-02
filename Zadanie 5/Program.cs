using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie
{
    class Program
    {
  
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string[] аргумент = Input.Split(' ');
            double x = Convert.ToDouble(аргумент[0]);
            double точность = Convert.ToDouble(аргумент[1]);
            double sum = 0;
            for (int n = 1; n < точность; n++)
            {
               double k = 0;
               double p = 0;
                k = Math.Pow(-1, n + 1);
                p = ((Math.Pow(x, 2 * n + 1)) / ((2 * n - 1) * (2 * n + 1)));
                sum = k * p;

            }
            Console.WriteLine(sum);
        }
    }
}

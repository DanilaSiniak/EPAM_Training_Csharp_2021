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
            Console.WriteLine("Введите ваш x и точность \n" +
                "Формат ввода: x пробел точность");
            string Input = Console.ReadLine();
            string[] аргумент = Input.Split(' ');
            double x = Convert.ToDouble(аргумент[0]);
            double точность = Convert.ToDouble(аргумент[1]);
            double sum = 0;
            int n = 0;
            while (Math.Pow(-1, n + 1) * ((Math.Pow(x, 2 * n + 1)) / ((2 * n - 1) * (2 * n + 1))) < точность);
            {
               
                n++;
                sum = Math.Pow(-1, n + 1) * ((Math.Pow(x, 2 * n + 1)) / ((2 * n - 1) * (2 * n + 1)));
                
            }
            Console.WriteLine("Значение суммы: ");
            Console.WriteLine(sum);
        }
    }
}

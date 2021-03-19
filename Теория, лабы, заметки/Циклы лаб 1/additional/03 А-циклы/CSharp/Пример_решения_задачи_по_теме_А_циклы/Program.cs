using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Пример_решения_задачи_по_теме_А_циклы
{
/*    Напишите программу нахождения суммы, включая в нее первые k слагаемых:

               k    ln^n(3)
         S = Summa  -------* x^n
               n=0     n!

     Спецификация ввода :
          k x
     Спецификация вывода:
          y
*/
    class Program
    {
        static void Main(string[] args)
        {
            string строкаВвода = Console.ReadLine();            //  В случае ввода аргументов из командной строки эту и ...
            string[] аргумент = строкаВвода.Split(' ');         //  эту строки надо закомментировать, а последующие две изменить на ...
            int k = Convert.ToInt16(аргумент[0]);               //  int k = Convert.ToInt16(args[0]);
            double x = Convert.ToDouble(аргумент[1]);           //  double x = Convert.ToDouble(args[1]);
            double слагаемое = 1.0, сумма = слагаемое;
            for (int n = 0; n < k; n++)
            {
                слагаемое *= Math.Log(3) * x / (n + 1);
                сумма += слагаемое;
            }
            Console.Write(сумма);
            Console.ReadLine();
        }
    }
}

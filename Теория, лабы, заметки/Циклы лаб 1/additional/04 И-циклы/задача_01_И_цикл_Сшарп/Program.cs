using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace задача_01_И_цикл_Сшарп
{
    /*     Решить уравнение:
                __
         3 sin\|x  + 0.35x - 3.8 = 0;

      используя метод Ньютона:
                           f(x_n)
          x_(n+1) = x_n - ---------
                           f'(x_n)
      Корень уравнения находится на отрезке [2; 3]. Контроль за окончанием просчетов
      проводить по малости невязки.      
 
         Спецификация ввода :
              a b точтость
         Спецификация вывода:
              значение решения
    */
    class Program
    {
        static double f(double x)
        {
            return 3 * Math.Sin(Math.Sqrt(x)) + 0.35 * x - 3.8;
        }
        static double fПроизводная(double x)
        {
            return 1.5 * Math.Cos(Math.Sqrt(x)) / Math.Sqrt(x) + 0.35;
        }
        static double fВтораяПроизводная(double x)
        {
            return -0.75 * (Math.Sqrt(x) * Math.Sin(Math.Sqrt(x)) + Math.Cos(Math.Sqrt(x))) / (x * Math.Sqrt(x));
        }
        static double начальноеПриближение(double a, double b)
        {
            return f(a) * fВтораяПроизводная(a) > 0 ? a : b;
        }
        static void вводДанных(out double a, out double b, out double точность)
        {
            string[] аргументы = Console.ReadLine().Split(' ');
            a = double.Parse(аргументы[0]);
            b = double.Parse(аргументы[1]);
            точность = double.Parse(аргументы[2]);
        }
        static void решениеЗадачи(double a, double b, double точность)
        {
            double приближение = начальноеПриближение(a, b);
            while (Math.Abs(f(приближение)) > точность) 
            {
                приближение = приближение - f(приближение) / fПроизводная(приближение);
            }
            Console.Write(приближение);
        }

        static void Main(string[] args)
        {
            double a, b, точность;
            вводДанных(out a, out b, out точность);
            решениеЗадачи(a, b, точность);
        }
    }
}

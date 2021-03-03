using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            double a = 0.5, b = 1;
            double value = a switch
            {
                _ when Func(a) * FuncSecondDerivative(a) > 0 => a,
                _ when Func(b) * FuncSecondDerivative(b) > 0 => b,
                _ => 0,
            };

            double x0, x1 = (a + b) / 2;
            double epsilon = 0.00000001;
            int i1 = 0;
            do
            {
                i1++;
                x0 = x1;
                x1 = x0 - Func(x0) / FuncDerivative(value);
            }
            while (Math.Abs(x0 - x1) > epsilon);

            Console.WriteLine($"Результат {x1} с {i1} этерациями");
        }

        public static double Func(double x)
        {
            return x + Math.Cos(Math.Pow(x, 0.52) + 2);
        }

        public static double FuncDerivative(double x)
        {
            return 1 - (13 * Math.Sin(Math.Pow(x, 0.52) + 2) / 25 * Math.Pow(x, 0.52));
        }
        public static double FuncSecondDerivative(double x)
        {
            return 13 * (-13 * Math.Cos(Math.Pow(x, 0.52) + 2) + (12 * Math.Sin(Math.Pow(x, 0.52) + 2)) / (Math.Pow(x, 0.52))); 
        }
    }
}
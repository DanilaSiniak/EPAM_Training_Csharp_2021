using System;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            Console.Write("Введите значение a: ");
            string userA = Console.ReadLine();
            double a = Convert.ToDouble(userA); 
            
            Console.Write("Введите значение b: ");
            string userB = Console.ReadLine();
            double b = Convert.ToDouble(userB); 
            
            Console.Write("Введите точность(epsilon): ");
            string userEpsilon = Console.ReadLine();
            double epsilon = Convert.ToDouble(userA); 
            
            double value = a switch
            {
                _ when Func(a) * FuncSecondDerivative(a) > 0 => a,
                _ when Func(b) * FuncSecondDerivative(b) > 0 => b,
                _ => 0,
            };

            double x0, x1 = (a + b) / 2;
            
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

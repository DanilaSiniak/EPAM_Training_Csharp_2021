using System;

namespace Zadanie3
{
    class Program
    {
        static double Fact(double value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k");

            /// Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine()); /// 
            double s = 0;

            for (int n = 1; n <= k; n++)
                s += Math.Pow(-1, n) * Math.Pow(x, 2*n) / Fact(2 * n);


            Console.WriteLine("Результат = {0}", s.ToString());  //// {} - плейсхолдеры, которые указывают места, в которые будет интерполироваться значение. 
            //// Число внутри скобок обозначает порядковый номер аргумента. Вместо числа может быть также имя переменной.
            Console.ReadKey();
        }
    }
}
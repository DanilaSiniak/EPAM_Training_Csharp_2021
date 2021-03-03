using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Введите корень, затем нажмите клавишу Enter: ");
            string userZ = Console.ReadLine();
            double Z = Convert.ToDouble(userZ); //// конвертация string в int


            Console.Write("Введите подкоренное выражение, затем нажмите клавишу Enter: ");
            string userN = Console.ReadLine();
            double N = Convert.ToDouble(userN); //// конвертация string в int

            Console.Write("Метод Math.Pow \n");
            double t = Math.Pow(Z, 1 / N);
            Console.WriteLine(t);
     

            Console.WriteLine(SqrtN(N, Z));
            Console.ReadKey();

        }

        static double Pow(double a, int pow)
        {
            double result = 1; //// 1, т.к будет операция умножения
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }


        static double SqrtN(double n, double A, double accuracy = 0.0001) ///// accuracy - точность 
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > accuracy)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            }
            Console.WriteLine("Окончательный результат равен:");
            return x1;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace задача_03
{
    /*
     *      Текстовый файл Inlet.in содержит целочисленные значения элементов массива A[0..N-1, 0..M-1].
     *      Подсчитать количество строк, среднее арифметическое элементов которых меньше заданной величины B.
     *   Результат решения задачи внести в файл Outlet.out.
     *   
     *           Спецификация ввода (файл Inlet.in):
     *               N B
     *               Значения элементов массива по строкам
     *           
     *           Спецификация вывода (файл Outlet.out):
     *               Количество строк, удовлетворяющих указанному в условии свойству
     */
    class Program
    {
        static StreamReader файлВВ = new StreamReader("Inlet.in");
        static StreamWriter файлЫВ = new StreamWriter("Outlet.out");

        static void Main(string[] args)
        {
            string[] N_B = файлВВ.ReadLine().Trim().Split(' ');
            int N = int.Parse(N_B[0]);
            int B = int.Parse(N_B[1]);
            int количество = 0;
            for (int i = 0; i < N; i++)
            {
                int сумма = 0;
                string[] элементСтроки = файлВВ.ReadLine().Trim().Split(' ');
                int k = элементСтроки.Length;
                foreach (string элемент in элементСтроки)
                {
                    сумма += int.Parse(элемент);
                }
                количество += сумма / k < B ? 1 : 0;
            }
            файлЫВ.Write(количество);
            Console.WriteLine(количество);
            файлЫВ.Close();
        }
    }
}

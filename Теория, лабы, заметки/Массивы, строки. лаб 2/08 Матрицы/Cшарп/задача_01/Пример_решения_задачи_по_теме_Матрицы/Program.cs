using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Пример_решения_задачи_по_теме_Матрицы
{
    /*   Текстовый файл Inlet.in содержит целочисленные значения элементов массива A[0..N-1, 0..M-1].
     * Переформировать его, упорядочив его строки по неубыванию их первых элементов.
     *   Результат решения задачи внести в файл Outlet.out.
     *   
     *       Примечание:
     *          Дополнительных массивов не использовать.
     *          
     *    Спецификация ввода (файл Inlet.in):
     *        N M
     *        Значения элементов массива по строкам
     *    Спецификация вывода (файл Outlet.out):
     *         Значения элементов преобразованного массива по строкам
     */ 
    class Program
    {
        static StreamReader ФайлIn = new StreamReader("1.in");
        static StreamWriter ФайлOut = new StreamWriter("outlet.out");
        static void вводДанных(out int N, out int M, out int[][] A)
        {
            string строкаВвода = ФайлIn.ReadLine();
            string[] аргумент = строкаВвода.Split(' ');
            N = Int16.Parse(аргумент[0]);
            M = Int16.Parse(аргумент[1]);
            A = new int[N][];
            for (int i = 0; i < N; i++)
                A[i] = new int[M];
            for (int i = 0; i < N; i++)
            {
                string элементыСтроки = ФайлIn.ReadLine().Trim(); // Рекомендуется делать для удаления крайних пробелов
                аргумент = элементыСтроки.Split(' ');
                int[] временный = new int[M];
                for (int j = 0; j < M; j++)
                    временный[j] = Int16.Parse(аргумент[j]);
                A[i] = временный;
            }
            ФайлIn.Close();
        }
        static int номерСтроки_с_МинимальнымЭлементом(int i, int[][] A)
        {
            int минимумПервых = A[i][0];
            int номерСтрокиМинимума = i;
            for (int j=i+1; j<A.Length; j++)
                if (минимумПервых > A[j][0])
                {
                    минимумПервых = A[j][0];
                    номерСтрокиМинимума = j;
                }
            return номерСтрокиМинимума;
        }
        static void переФормированиеМассива(ref int[][] A)
        {
            int[] B = new int[A[0].Length];
            for (int i = 0; i < A.Length-1; i++)
            {
                int j = номерСтроки_с_МинимальнымЭлементом(i, A);
                if (i != j)
                {
                    B = A[i];
                    A[i] = A[j];
                    A[j] = B;
                }
            }
        }
        static void выводРезультата(int[][] B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                string строкаВывода = "";
                for (int j = 0; j < B[i].Length; j++)
                    строкаВывода += " " + B[i][j];
                строкаВывода = строкаВывода.Trim();
                ФайлOut.WriteLine(строкаВывода);
            }
            ФайлOut.Close();
        }
        static void Main(string[] args)
        {
            int N, M;
            int[][] A;
            вводДанных(out N, out M, out A);
            переФормированиеМассива(ref A);
            выводРезультата(A);
        }
    }
}

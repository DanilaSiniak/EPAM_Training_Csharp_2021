using System;
using System.IO;
using System.Text;
/*
 * Дан линейный массив A[1..N], содержащий целые числа.
 * Выделить те элементы этого массива в массив B, индексы которых являются степенями числа C.
 *    Спецификация ввода	:
 *      N С
 *  	Значения элементов массива А по одному в строке
 *    Спецификация вывода	:
 *      Значения элементов массива В в строку через пробел 
 *      
 */
namespace Пример_решения_задачи_по_теме_Векторы
{
    class Program
    {
        static StreamReader файлIn = new StreamReader("Inlet.in");
        static StreamWriter файлOut = new StreamWriter("outlet.out");

        static void Main(string[] args)
        {
            int N, C;
            int[] A, B;
            вводДанных(out N, out C, out A);
            формированиеМассива(C, A, out B);
            выводРезультата(B);
        }
        static void вводДанных(out int N, out int C, out int[] A)
        {
            string строкаВвода = файлIn.ReadLine();
            string[] аргумент = строкаВвода.Split(' ');
            N = Convert.ToInt16(аргумент[0]); //Int16.Parse(аргумент[0]);
            C = Int16.Parse(аргумент[1]);
            A = new int[N];
            for (int i = 0; i < N; i++)
            {
                string число = файлIn.ReadLine();
                A[i] = Int16.Parse(число);
            }
            файлIn.Close();
        }
        static void формированиеМассива(int C, int[] A, out int[] B)
        {
            /*        Наша задача найти такой показатель k, что c^k = N. 
             *    Если прологорифмировать последнее "равенство" по основанию с, то получим 
             *    log_с(N) = k.
             *    Поскольку речь идет только о целочисленных результатах (индексах), то надо брать 
             *    целую часть частного + 1.
             */

            int k = C == 1 ? 1 : (int)Math.Floor(Math.Log(A.Length, C)) + 1;
            B = new int[k];
            for (int i = 0; i < k; i++)
            {
                int j = (int)Math.Pow(C, i);
                B[i] = A[j - 1];
            }
        }
        static void выводРезультата(int[] B)
        {
            string строкаВывода = "";
            for (int i = 0; i < B.Length; i++)
                строкаВывода += " " + B[i];
            строкаВывода = строкаВывода.Trim();
            файлOut.Write(строкаВывода);
            файлOut.Close();
        }
    }  
}

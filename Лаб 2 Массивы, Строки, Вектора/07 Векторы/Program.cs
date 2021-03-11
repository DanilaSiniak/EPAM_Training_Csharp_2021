﻿using System;
using System.IO;
namespace Lab4
{
    class Program
    {
        static StreamReader Input = new StreamReader("Input.txt");
       

        /// Первая строка в документе, количество элементов массива, последующие строки - элементы массив
    
        static void Main(string[] args)
        {
            
            int n = int.Parse(Input.ReadLine());
            int[] mas = new int[n];
            int i, k = 0;


            Console.WriteLine("Исходный массив");
            for (i = 0; i < n; i++)
            {
              
                mas[i] = int.Parse(Input.ReadLine());
            }
            using (StreamWriter sw = new StreamWriter("Output.txt", false, System.Text.Encoding.Default))
            {
                for (i = 1; i < n - 1; i++)
                {
                    if ((mas[i] < mas[i - 1]) && (mas[i] < mas[i + 1]))
                    {
                        sw.WriteLine($"Локальный минимум = {mas[i]}");
                        k++;
                    }

                }
            }
            Console.WriteLine();

        }
    }
}
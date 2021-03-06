using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputFile = new StreamReader("Inlet.txt");
            StreamWriter outputFile = new StreamWriter("Outlet.txt");
            int n = int.Parse(inputFile.ReadLine());
            char[] space = { ' ' };
            string[] astr = inputFile.ReadLine().Split(space, StringSplitOptions.RemoveEmptyEntries);
            int количество = 0;
            int i, k = 0;
            for (int i = 1; i < количество - 1; i++)
            {
                if ((astr[i] < astr[i - 1]) && (astr[i] < astr[i + 1]))
                {
                    Console.WriteLine($"Локальный минимум[{k + 1}] = {astr[i]}");
                    k++;
                }
                if (k == 0)
                {
                    Console.Write("Локальных минимумов не найдено.");
                };
            }
            outputFile.Write(astr);
            outputFile.Write(k);
            outputFile.Write(количество);
            outputFile.Close();
        } 
    }
}
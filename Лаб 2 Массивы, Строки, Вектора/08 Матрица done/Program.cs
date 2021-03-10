using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       //////////////////// чтение с файла //////////////////
        string[] s = File.ReadAllLines("Input.txt");
        int[][] array = (from i in s
                         select i.Trim().Split(' ').
                         Select(x => int.Parse(x.Trim())).ToArray()).ToArray();
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(array[i][j]);
            }
            Console.WriteLine();
        }
        // получаем кол-во строк 
        int length1 = 7;
        // получаем кол-во столбцов 
        int length2 = 6;
        //объявляем коллекции для хранения нулевых строк и столбцов
        List<int> ls1 = new List<int>();
        List<int> ls2 = new List<int>();

        Console.WriteLine("======Исходная матрица=========");
        // выводим матрицу на консоль и находим нулевые строки
        for (int i = 0; i < length1; ++i)
        {
            bool b = false;
            for (int j = 0; j < length2; ++j)
            {
                if (array[i][j] >= 0)
                    Console.Write("  " + array[i][j]);
                else Console.Write(" " + array[i][j]);
                if (array[i][j] != 0) b = true;
            }
            if (!b) ls1.Add(i);
            Console.WriteLine();
        }
        //  находим нулевые столбцы
        for (int i = 0; i < length2; ++i)
        {
            bool b = false;
            for (int j = 0; j < length1; ++j)
            {

                if (array[j][i] != 0) b = true;
            }
            if (!b) ls2.Add(i);

        }
        //  Удаляем нулевые строки и столбцы 
        bool B = false; int? Istr = null;
        Console.WriteLine("======Удаляем нулевые строки и столбцы=========");
        for (int i = 0; i < length1; ++i)
        {
            if (!ls1.Contains(i))
            {
                for (int j = 0; j < length2; ++j)
                {
                    if (!ls2.Contains(j))
                    {
                        if (array[i][j] >= 0)
                        {
                            if (!B)
                            {
                                Istr = i;
                                B = true;
                            }
                            Console.Write("  " + array[i][j]);
                        }
                        else Console.Write(" " + array[i][j]);
                    }

                }

            }
            if (!ls1.Contains(i))
                Console.WriteLine();
        }
        ///////////////////////// Запись в файл ////////////////////////
        Console.ReadKey();
        s = File.ReadAllLines("Input.txt");
        array = (from i in s
                 select i.Trim().Split(' ').
                 Select(x => int.Parse(x.Trim())).ToArray()).ToArray();
        using (StreamWriter sw = new StreamWriter("Output.txt", false, System.Text.Encoding.Default))
        {
            string same = "";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    same += array[i][j] + " ";
                }
                sw.Write(same);
                same = "";
            }
        }
    }
}

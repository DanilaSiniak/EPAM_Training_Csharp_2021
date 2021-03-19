using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace задача_13
{
    /*
     *    Дан текстовый файл Inlet.in, содержащий строковые величины S. В последней его строке находится 
     *  целочисленная величина k.
     *    Переставить в данных строковых величинах последовательно слова, длина которых равна k следующим образом : 
     *  первое найденное слово расположить с позиции первого слова исходной строковой величины, завершая его символом 
     *  «пробел», второе найденное слово – после первого вставленного тоже с завершающим его разделительным символом 
     *  «пробел» и так далее, пока будут обнаруживаться в преобразуемой строке S слова указанной длины.
     *    Прочие слова исходного текста «отодвигаются» по строке вправо.
     *    
     *      Например. 
     *         Исходный текст : k = 8 и S=« Коллоквиум – дело полезное».
     *         Преобразовать в строку вида – « полезное Коллоквиум – дело »
     *         
     *      Определение. Слово - это последовательность символов строковой величины, не содержащая в себе символ пробела.
     *      
     *      Спецификация ввода (файл Inlet.in):
     *         Строковая величина
     *         Строковая величина
     *         . . . . . . . . . . . . . . . . . . . . .
     *         Строковая величина
     *         Целое число k
     *      Спецификация вывода (файл Outlet.out):
     *         Последовательность преобразованных величин
     *  
     */
    class Program
    {
        static StreamReader файлВВ = new StreamReader("Inlet.in");
        static StreamWriter файлЫВ = new StreamWriter("Outlet.out");


        static void Main(string[] args)
        {
            string[] строка;
            int k;
            вводДанных(out строка, out k);
            строка = преобразованиеСтрок(строка, k);
            for (int i = 0; i < строка.Length-1; i++)
            {
                файлЫВ.WriteLine(строка[i]);
            }
            файлЫВ.Write(строка[строка.Length - 1]);
            файлЫВ.Close();
        }
        static string[] преобразованиеСтрок(string[] строка, int k)
        {
            string[] строкаВывода = new string[строка.Length - 1];
            for (int i = 0; i < строка.Length - 1; i++)
            {
                строкаВывода[i] = преобразованиеСтроки(строка[i], k);
            }
            return строкаВывода;
        }
        static string преобразованиеСтроки(string строка, int k)
        {
            StringBuilder новаяСтрока = new StringBuilder();
            StringBuilder cтрокаСловДлинойk = new StringBuilder();
            for (int i = 0; i < строка.Length;)
            {
                StringBuilder пробелы = new StringBuilder();
                StringBuilder слово = new StringBuilder();
                while (i < строка.Length && строка[i]==' ')
                {
                    пробелы.Append(строка[i]);
                    i++;
                }
                while (i < строка.Length && строка[i] != ' ')
                {
                    слово.Append(строка[i]);
                    i++;
                }
                if (слово.Length == k)
                {
                    cтрокаСловДлинойk.Append(слово);
                    cтрокаСловДлинойk.Append(' ');
                    новаяСтрока.Append(пробелы);
                }
                else
                {
                    новаяСтрока.Append(пробелы);
                    новаяСтрока.Append(слово);
                }
            }
            if (cтрокаСловДлинойk.Length != 0)
            {
                cтрокаСловДлинойk.Append(новаяСтрока);
                return cтрокаСловДлинойk.ToString();
            }
            else
                return новаяСтрока.ToString();
        }
        static void вводДанных(out string[] строка, out int k)
        {
            char[] разделитель = { '\r', '\n' };
            строка = файлВВ.ReadToEnd().Split(разделитель,StringSplitOptions.RemoveEmptyEntries);
            k = int.Parse(строка[строка.Length - 1]);
        }
    }
}

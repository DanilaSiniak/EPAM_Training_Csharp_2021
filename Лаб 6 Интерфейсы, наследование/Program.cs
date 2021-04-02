using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Interfeis
{
    /// <summary>
    ///  
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] Elements =
            {
                new ProgramHelper(),
                new ProgramConverter(),
       
            };
            ProgramHelper[] ProgramHelperVariable = new ProgramHelper[5];
            ProgramConverter[] ProgramConverterVariable = new ProgramConverter[5];
            string CodeString, Language;

            //// Код на языке C# заканчивается на заглавную букву C
            //// Код на языке VB заканчивается на заглавную букву V

            Console.Write("Напишите код, если вы хотите написать C# код, то в конце строки оставьте C. Если VB код, то оставьте в конце строки V): ");
            Console.WriteLine("Для продолжения нажмите Enter ( после заполнения )");
            CodeString = Console.ReadLine();


            Console.WriteLine("Напишите название языка программирования: ");
            Console.WriteLine("Для продолжения нажмите Enter ( после заполнения )");
            Language = Console.ReadLine();

            for (int i = 0; i < Elements.Length; i++)
            {
                if (Elements[i] as ICodeChecker != null)
                {
                    Console.WriteLine($"{i + 1}. Реализует интерфейс ICodeChecker:");
                    ProgramHelper Helper = new ProgramHelper();
                    if (Helper.CodeCheckSyntax(CodeString, Language))
                    {
                        if (Language == "C#")
                        {
                            Console.WriteLine(Elements[i].ConvertToVB(CodeString));
                            Console.WriteLine("Для продолжения нажмите Enter");
                            Console.ReadLine();
                        }
                        else if (Language == "VB")
                        {
                            Console.WriteLine(Elements[i].ConvertToSharp(CodeString));
                            Console.WriteLine("Для продолжения нажмите Enter");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Язык программирования неверный!");
                        Console.WriteLine("Для продолжения нажмите Enter");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Выполняется два метода преобрзования:");
                    Console.WriteLine("Для продолжения нажмите Enter");
                    Console.ReadLine();
                    Console.WriteLine(Elements[i].ConvertToSharp(CodeString));
                    Console.WriteLine("Для продолжения нажмите Enter");
                    Console.ReadLine();
                    Console.WriteLine(Elements[i].ConvertToVB(CodeString));
                    Console.WriteLine("Для продолжения нажмите Enter");
                    Console.ReadLine();
                }
            }
        }
    }
}
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
            ProgramHelper[] ProgramHelperVariable = new ProgramHelper[5];
            ProgramConverter[] ProgramConverterVariable = new ProgramConverter[5];
            string CodeString, Language;

            //// Код на языке C# заканчивается на заглавную букву C
            //// Код на языке VB заканчивается на заглавную букву V

            Console.Write("Напишите код, если вы хотите написать C# код, то в конце строки оставьте C. Если VB код, то оставьте в конце строки V): ");
            CodeString = Console.ReadLine();


            Console.Write("Напишите название языка программирования: ");
            Language = Console.ReadLine();

            Console.WriteLine("Нажимайте Enter несколько раз: ");
            Console.ReadLine();

            Console.WriteLine("Статус интерфейса ProgramHelper: ");
            for (int i = 0; i < ProgramHelperVariable.Length; i++)
            {
                ProgramHelperVariable[i] = new ProgramHelper();
                if (ProgramHelperVariable[i] is ICodeChecker)
                {
                    if (ProgramHelperVariable[i].CodeCheckSyntax(CodeString, Language))
                    {
                        if (Language == "C#")
                        {
                            Console.WriteLine(ProgramHelperVariable[i].ConvertToVB(CodeString));
                            Console.ReadLine();


                        }
                        else if (Language == "VB")
                        {
                            Console.WriteLine(ProgramHelperVariable[i].ConvertToSharp(CodeString));
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(ProgramHelperVariable[i].ConvertToSharp(CodeString));
                    Console.ReadLine();
                    Console.WriteLine(ProgramHelperVariable[i].ConvertToVB(CodeString));
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Статус интерфейса ProgramConverter: ");
            for (int i = 0; i < ProgramConverterVariable.Length; i++)
            {
                ProgramConverterVariable[i] = new ProgramConverter();
                if (!(ProgramConverterVariable[i] is ICodeChecker))
                {
                    if (Language == "C#")
                    {
                        Console.WriteLine(ProgramConverterVariable[i].ConvertToVB(CodeString));
                        Console.ReadLine();
                    }
                    else if (Language == "VB")
                    {
                        Console.WriteLine(ProgramConverterVariable[i].ConvertToSharp(CodeString));
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine(ProgramConverterVariable[i].ConvertToSharp(CodeString));
                    Console.ReadLine();
                    Console.WriteLine(ProgramConverterVariable[i].ConvertToVB(CodeString));
                    Console.ReadLine();
                }
            }
        }
    }
}

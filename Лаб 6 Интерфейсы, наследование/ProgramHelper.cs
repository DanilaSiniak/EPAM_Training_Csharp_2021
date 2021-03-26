using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Interfeis
{
    class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public new string ConvertToSharp(string str)
        {
            return "Конвертировани в C# выполнено успешно!";
        }

        public new string ConvertToVB(string str)
        {
            return "Конвертировани в VB выполнено успешно!";
        }

        //// Код на языке C# заканчивается на заглавную букву C
        public bool CodeCheckSyntax(string veritificationString, string languageUsed)
        {
            if (languageUsed == "C#")
            {
                if (veritificationString[veritificationString.Length - 1] == 'C')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
            //// Код на языке VB заканчивается на заглавную букву V
            else if (languageUsed == "VB")
            {
                if (veritificationString[veritificationString.Length - 1] != 'V')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

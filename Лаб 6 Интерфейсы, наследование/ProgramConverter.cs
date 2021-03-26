using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6Interfeis
{
    class ProgramConverter : IConvertible
    {
        public string ConvertToSharp(string str)
        {
            return "Конвертирование в C# выполнено успешно!";
        }

        public string ConvertToVB(string str)
        {
            return "Конвертирование в VB выполнено успешно!";
        }
    }
}

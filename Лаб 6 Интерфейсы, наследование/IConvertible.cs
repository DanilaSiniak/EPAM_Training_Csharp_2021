using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab6Interfeis 
{
   public interface IConvertible
    {
        /* ConvertToSharp() конвертирует VB код в C# код. */
        string ConvertToSharp(string VBtoSharpCode);

        /* ConvertToVB() конвертирует C# код в VB код. */
        string ConvertToVB(string SharpCodeToVB);

    }
}

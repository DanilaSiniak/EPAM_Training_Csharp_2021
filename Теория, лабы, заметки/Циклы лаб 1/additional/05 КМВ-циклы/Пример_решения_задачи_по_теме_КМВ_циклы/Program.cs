using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Пример_решения_задачи_по_теме_КМВ_циклы
{
    /*    Найти сумму, закончив просчеты, как только абсолютная величина слагаемого станет
     * меньше величины переменной "точность":
     *                      5*x^4     7*x^6 
     *      S = 1 + 3x^2 + ------- + ------- + ...
     *                        2         6
     *     Спецификация ввода :
     *          x точность
     *     Спецификация вывода:
     *          значение суммы
     */
    class Program
    {
        static void Main(string[] args)
        {
            string строкаВвода = Console.ReadLine();
            string[] аргумент = строкаВвода.Split(' ');
            double x = Convert.ToDouble(аргумент[0]);
            double точность = Convert.ToDouble(аргумент[1]);
            double слагаемое = 1, сумма = 0;
            int k =0;
            while ((2*k+1)*слагаемое>точность)
            {
                сумма+=(2*k++ +1)*слагаемое;
                слагаемое*=x*x/k;
            }
            Console.WriteLine(сумма);
        }
    }
}

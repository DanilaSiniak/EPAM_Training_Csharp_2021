using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Class__geometric_figures
{
    /*
      
      Разработать класс геометрической фигуры по варианту, заданной на плоскости линейными размерами
      (например, сторонами a, b, c в случае треугольника).
      Предусмотреть возможность проверки существования фигуры, реализовать функции подсчета его
      площади и периметра.
      Вариант 5: Пятиугольник
             
     */
    class Pentagon   //// Pentagon - пятиугольник 
    {
        double sideofPentagon;

        public Pentagon(double sideofPentagon)
        {
            this.sideofPentagon = sideofPentagon;
        }

        /// check to right input date /// 
        /// 
        public int CheckInputDate
        {
            get
            {
                if (sideofPentagon <= 0)
                {
                    return -1;
                }
                return 1;
            }
        }

        /// square of pentagon /// 
        /// 

        public double SquareOfPentagon()
        {

            return 2.5 * sideofPentagon * Math.Sqrt(Math.Pow(sideofPentagon / (2 * Math.Sin(Math.PI / 5)), 2) - (Math.Pow(sideofPentagon, 2) / 4));
        }

        /// perimetr of pentagon /// 
        /// 
        public double PerimetrOfPentagon()
        {

            return 5 * sideofPentagon;
        }
    }

    class Program
    {
        static int Main(string[] argc)
        {
            Console.Write("Введите длину стороны пятиугольника: ");
            string side = Console.ReadLine();
            double sideofPentagon = Convert.ToDouble(side);

          
            Pentagon pentagon;
            pentagon = new Pentagon(sideofPentagon);

          

            if (pentagon.CheckInputDate == -1)
            {
                Console.WriteLine("Входные данные неверны!");
                Console.ReadLine();
                return 0;
            }
            else
            {
                Console.WriteLine("Площадь пятиугольника " +  pentagon.SquareOfPentagon());
                Console.WriteLine("Периметр пятиугольника " + pentagon.PerimetrOfPentagon());
                Console.ReadLine();

            }
            Console.ReadLine();
            return 0;
        }
    }
}

    

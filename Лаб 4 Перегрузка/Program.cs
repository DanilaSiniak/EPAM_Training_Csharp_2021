using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Vector
    {

        private int x;
        private int y;
        private int z;


        public Vector(int X, int Y, int Z)
        {//копирующий конструктор;

            x = X;
            y = Y;
            z = Z;

        }

        public int X 
        {
            get
            {
                return x;
            }
         }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
        }



        /// Перегрузка 
        public static Vector operator + (Vector v1, Vector v2)
        {
            
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }


        public static Vector operator *(Vector v1, Vector v2)
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        ///// произведение векторов
        public static int VectorMultiplication(Vector v1, Vector v2)
        {
            return ((v1.Y * v2.Z - v1.Z * v2.Y) - (v1.X * v2.Z - v1.Z * v2.X) + (v1.X * v2.Y - v1.Y * v2.X));
        }


        public static int VectorProduct(Vector v1, Vector v2)
        {
            return ((v1.X * v2.X ) + (v1.Z * v2.Z) + (v1.Y*v2.Y));
        }


        //// Формат вывода строки ////
        public override string ToString()
        {
            return "{" + X + ", " + Y + ", " + Z + "}";
        }


    }
    class Program
    {



        static void Main(string[] args)
        {
            int x, y, z;
            int x1, y1, z1;

            Console.WriteLine("Введите значение первого вектора x y z: ");
            string textV1 = Console.ReadLine();
            string[] numbers1 = textV1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            x = Convert.ToInt32(numbers1[0]);
            y = Convert.ToInt32(numbers1[1]);
            z = Convert.ToInt32(numbers1[2]);

            Console.WriteLine("Введите значение первого вектора x1 y1 z1: ");
            string textV2 = Console.ReadLine();
            string[] numbers2 = textV2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            x1 = Convert.ToInt32(numbers2[0]);
            y1 = Convert.ToInt32(numbers2[1]);
            z1 = Convert.ToInt32(numbers2[2]);


            Vector v1 = new Vector(x, y, z);
            Vector v2 = new Vector(x1, y1, z1);

            Vector VectorProiz = v1 * v2;
            ///// Сумма векторов
            Vector VectorSum = v1 + v2;
            ///// Разность векторов
            Vector VectorSubsr = v1 - v2;

            int vectorMultiplication = Vector.VectorMultiplication(v1, v2);



            Console.WriteLine("Первый исходный вектор: " + v1 +
                            "\nВторой исходный вектор: " + v2 +
                            "\n" +
                            "\nСумма векторов: " + VectorSum +
                            "\nВычитание векторов: " + VectorSubsr +
                            "\nПроизведение векторов " + VectorProiz +
                            "\nСкалярное произведение векторов: " + vectorMultiplication);

            Console.ReadLine();
        }
    }
        
}

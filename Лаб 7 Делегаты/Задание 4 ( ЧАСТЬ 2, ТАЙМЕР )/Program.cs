using System;
using System.Threading;

namespace DelegatiTimer
{
    public delegate void TimerDelegate();
    public delegate void TimeLeftDelegate(int Number);

    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "Reading exercise", "Realization exercise", "Check exercise" };
            int[] Number = new int[3];

            Console.Write("How many time left for reading exercise: ");
            Number[0] = int.Parse(Console.ReadLine());
            Console.Write("How many time left for realization exercise: ");
            Number[1] = int.Parse(Console.ReadLine());
            Console.Write("How many time left for check exercise: ");
            Number[2] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ICutDownNotifier[] Elements =
            {
                new ReadingExerciseClass(Number[0], Name[0]),
                new RealizationExerciseClass(Number[1], Name[1]),
                new CheckExerciseClass(Number[2], Name[2])
            };

            for (int i = 0; i < Elements.Length; i++)
            {
                Elements[i].Run();
            }
        }
    }
}
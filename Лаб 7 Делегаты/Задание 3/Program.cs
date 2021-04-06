using System;
using DelegateZadanie3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateZadanie3
{

    /*
       Создать приложение, в котором генератор события после генерации первого события генерирует последующие события только в том случае, 
       если приемник события уведомляет, что событие принято (квитирование). Для квитирования использовать второй параметр обработчика события. 
    */
    class Program : EventGenerator
    {
        const int EVENTCOUNTER = 10;
        static void Main(string[] args)
        {
            EventGenerator generator = new EventGenerator();
            generator.GeneratorEvent += new EventHandler(generator_GeneratorEvent);
            generator.StartGenerate();
            Console.ReadLine();
        }

        static void generator_GeneratorEvent(object sender, EventArgs e)
        {
            EventGenerator g = sender as EventGenerator;
            if (g != null & g.GenerationCount == 0)
            {
                g.GenerationCount = EVENTCOUNTER;
            }
            Console.WriteLine("Got Event!");
        }
    }


}

public class TwoParametrEventArgs : EventArgs { }


public class EventGenerator
{
   
    public event EventHandler GeneratorEvent = delegate { };
    public int GenerationCount { get; set; }
    public static TwoParametrEventArgs pTP = new TwoParametrEventArgs();
    public void StartGenerate()
    {
        do
        {
            GeneratorEvent(this, pTP);
            if (GenerationCount > 0)
            {
                GenerationCount -= 1;
            }
            Thread.Sleep(1000);
        }
        while (GenerationCount != 0);

    }
}


using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiTimer
{
    class RealizationExerciseClass : ReadingExerciseClass
    {
        public RealizationExerciseClass(int NumberOfSeconds, string Name) : base(NumberOfSeconds, Name) { }

        public new void Init()
        {
            timer = new Timer(NumberOfSeconds, TimerName);
            timer.RunTimer += delegate ()
            {
                int Counter = 0;
                Console.WriteLine(TimerName + ":" + NumberOfSeconds);
                for (int i = 1; i <= NumberOfSeconds; i++)
                {
                    Thread.Sleep(1000);
                    if (Counter == NumberOfSeconds)
                    {
                        timer.OnTimeLeft(i);
                        Counter = -1;
                    }
                    Counter++;
                }
                timer.OnEndCounting();
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiTimer
{
    class ReadingExerciseClass : Timer, ICutDownNotifier
    {
        public ReadingExerciseClass(int Number, string Name) : base(Number, Name) { }

        public Timer timer = null;

        public void Init()
        {
            timer = new Timer(NumberOfSeconds, TimerName);
            timer.RunTimer += timer.StartCounting;
            timer.TimeLeft += timer.OnTimeLeft;
            timer.EndTimer += timer.OnEndCounting;
        }

        public void Run()
        {
            if (timer == null)
            {
                Init();
            }
            timer.TimerRun();
        }
    }
}

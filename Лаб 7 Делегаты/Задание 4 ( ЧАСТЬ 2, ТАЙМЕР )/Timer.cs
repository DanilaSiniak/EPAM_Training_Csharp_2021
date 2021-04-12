using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatiTimer
{
    class Timer
    {
        public event TimerDelegate RunTimer = null;
        public event TimeLeftDelegate TimeLeft = null;
        public event TimerDelegate EndTimer = null;

        public string TimerName { get; set; }
        public int NumberOfSeconds { get; set; }

        public Timer(int NumberOfSeconds, string Name)
        {
            this.NumberOfSeconds = NumberOfSeconds;
            TimerName = Name;
        }

        public Timer() { }

        public void TimerRun()
        {
            Console.WriteLine(RunTimer.Target + "\nСurrent: " + TimerName);
            RunTimer?.Invoke();
        }

        public void OnTimeLeft(int Seconds)
        {
            Console.WriteLine($" {NumberOfSeconds - Seconds} seconds left");
        }

        public void OnEndCounting()
        {
            Console.WriteLine("Timer complete \n");
        }

        public void StartCounting()
        {
            int Counter = 0;
            for (int i = 1; i <= NumberOfSeconds; i++)
            {
                Thread.Sleep(1000);
                if (Counter == NumberOfSeconds / 10000)
                {
                    TimeLeft(i);
                    Counter = -1;
                }
                Counter++;
            }
            EndTimer();
        }
    }
}

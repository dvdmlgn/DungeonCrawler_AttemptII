using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DungeonCrawler
{
    public static class Timers
    {
        private static DispatcherTimer timer = new DispatcherTimer();
        private static Stopwatch DeltaTimer = new Stopwatch();

        private static double DeltaTime { get; set; }
        private static double FrameTime { get; set; }

        private static double TargetFramerate = 16.6667; // an approximation for 60fps, in milliseconds



        public static void Start()
        {
            timer.IsEnabled = true;
            timer.Interval = TimeSpan.FromMilliseconds(TargetFramerate);
            timer.Tick += OnTimerTick;
        }

        private static void OnTimerTick(object sender, EventArgs e)
        {
            DeltaTimer.Restart();

            ApplicationManager.ApplicationLoop();



            //@Debug
            //labelEscTest.Content = isPause;

            DeltaTime = DeltaTimer.ElapsedMilliseconds;

            if(DeltaTime < TargetFramerate)
            {
                FrameTime = TargetFramerate - DeltaTime;

                timer.Interval = TimeSpan.FromMilliseconds(FrameTime);
            }

            else
            {
                timer.Interval = TimeSpan.FromMilliseconds(0);
            }


        }
    }
}

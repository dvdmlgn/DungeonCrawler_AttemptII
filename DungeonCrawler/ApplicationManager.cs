using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DungeonCrawler
{
    public static class ApplicationManager
    {

        // -- Check for Esc key press -----------------------------
        private static bool isEsc = false;
        private static bool isDown = false;

        // -- for State Manager -----------------------------
        private static bool isPause = false;


        public static void StartApplication()
        {
            Timers.Start();
        }

        public static void ApplicationLoop()
        {


            PauseCheck();

            StateMachine();

            if(!isPause)
            {
                Game.GameLoop();
            }


  
        }


        private static void PauseCheck()
        {
            if (!isDown)
            {

                if (Keyboard.IsKeyDown(Key.Escape))
                {
                    isEsc = !isEsc;

                    isDown = true;
                }

            }


            if (Keyboard.IsKeyUp(Key.Escape))
            {

                isDown = false;
            }

            isPause = isEsc;

            //@Debug
            //MainWindow.isPause = isEsc;

        }

        private static void StateMachine()
        {
            if(isPause)
            {
                MainWindow.pauseGridRef.Visibility = System.Windows.Visibility.Visible;

                MainWindow.pauseMenuRef.Focus();
            }

            else
            {
                MainWindow.pauseGridRef.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

    }


    
}

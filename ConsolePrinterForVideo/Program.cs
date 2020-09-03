using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsolePrinterForVideo
{
    class Program
    {
        public static int PRINT_SPEED = 20;
        public static int DEF_DELAY = 400;
        public static ConsoleColor DEF_CONSOLE_COLOR = ConsoleColor.Green;
        public static Random random = new Random();

        static void Main(string[] args)
        {
            Console.ReadKey();
            //Init console def color
            Console.ForegroundColor = DEF_CONSOLE_COLOR;
            Console.CursorSize = Console.CursorSize * 2;
            scene_001();

            Console.ReadKey();
        }

        public static void scene_001() {
            
            //Initializing
            printText("Initializing");
            printText("...", 1000);
            delay(750);
            printText(" Done\n");
            delay(150);
            //Connection
            printText("Establishing connection");
            printText("...\n", 500);
            delay(750);
            printError("[Error] - could not connect to the global controlling system.\n");
            printError("[Error] - the server does not respond.\n");
            printError("[Error] - default RF device corrupted\n");
            printError("[Error] - could not load default emergency device\n");
            printError("[Error] - If you see this error it means something is going very wrong in the communication system, I disabled additional error messages, \n" +
                "we have to finish this soon so remind Mike to fix this, it is very unsecure bug!!! " +
                "I would like Mike to call me as soon as possible!!! This is important!!! Do not ignore!!!\n", 4);
            delay(200);
            printError("[Error] - internal error, the communication system is broken. Restarting does no effect.");
            delay(300);
            printText(" Done\n");
            delay(150);
            //Connecting additional stuff
            printText("Connecting additional devices");
            printText("...\n", 500);
            printError("[Error] - some devices require drivers, could not connect to the server.\n");
            printText(" Done\n");
            //List
            string[] arr = { "Sound", "Video", "Sensors array system", "Engine drivers", "K-86 loader", "KLFTMP", "Control system", "Peripheral", "Communicatin system", "EFS system", "MPR?D"};

            foreach (string val in arr) {
                printText(val, -1, true);
                printText("...", 150);
                for (int i = 0; i < 40 - 3 - val.Length; i++) Console.Write(" ");
                if (val == "Communicatin system") {
                    printError("Unable to connect");
                    continue;
                }
                printText("Established\n");
            }
            printText("Establishing successful!\n");
            delay(300);
            
            //Launching
            printText("Launching... \n", ConsoleColor.Blue);
            printText("Current time: unknown\n", ConsoleColor.Blue);
            printText("Current location: unknown\n", ConsoleColor.Blue);
            printText("Current state: stable\n", ConsoleColor.Blue);
            printText("Current destination: engine room\n", ConsoleColor.Blue);
            printText("Current task: no task\n", ConsoleColor.Blue);
            delay(500);
            printText("Current mission: missi ssi    dun  dk       sk       ka\n dfs  erg ewrr     edr\n fsf??????????????????????????????????\n|||||||||||????????????????????\n????????????????????\n", ConsoleColor.Blue);
            printError("[Fatal error] - virus in the system\n");
            delay(200);
            printError("[Fatal error] - virus in the system\n");
            printError("[Fatal error] - vi us in the system\n");
            printError("[Fatal error] - virus in the sy tem\n");
            printError("[Fatal error] - virus i  t e sys em\n");
            printError("[Fatal error] - virus i  t e sys em\n");
            printError("[Fa al  r or] - v   s i  t   s s  m\n");
            printError("[Fa al  r or] -  i  s i  t   s s  m\n");
            printError("[Fa al  r or] - v   s i    e s y  m\n");
            printError("[       r or  ?     ?        ?    ?\n");
            printError("[       r or  ?     ?        ?    ?\n");
            printError("    ?           ?      ??   ?      \n");
            printError("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            printError("Trying to reboot");
            printError("Trying to reboot");
            printError("Trying to reboot");
            printError("[Err r  - trying to reb?ot cou?dnot be re??lved");
            printError("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            delay(400);
            printError("\n\n\n\n\n                 ?\n\n\n\n\n         ?                ?\n\n\n\n     e\n\n\n");
            delay(500);
            printError("\n\ne\n\n\n\n\n  m\n\n\n\n  ??  ??\n\n\n??? \n\n\n");
            delay(600);
            printText("Launching... \n", ConsoleColor.Blue);
            printText("Current time: 08.08.2050\n", ConsoleColor.Blue);
            printText("Current location: 290F.hFg6.68DF.782h.784G\n", ConsoleColor.Blue);
            printText("Current state: critical\n", ConsoleColor.Yellow);
            printText("Current destination: engine room\n", ConsoleColor.Blue);
            printText("Current task: \n", ConsoleColor.Blue);
            printText("\n\n\nLoaded", ConsoleColor.Blue);
        }

        public static void delay(int timeToDelay) {
            Thread.Sleep(timeToDelay);
        }

        public static void printText(string textToPrint, int printSpeed = -1, bool isdefDelay = true) {
            if (printSpeed < 0) printSpeed = PRINT_SPEED;
            foreach(char ch in textToPrint) {
                if (random.Next(1, 80) != 1)
                {
                    Console.Write(ch);
                }
                else
                {
                    var oldColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write(' ');
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = oldColor;
                }
                Thread.Sleep(printSpeed);
            }
            if (isdefDelay) delay(random.Next(DEF_DELAY, DEF_DELAY*2));
        }
        public static void printText(string textToPrint, ConsoleColor foregroundColor)
        {
            Console.ForegroundColor = foregroundColor;
            printText(textToPrint);
            Console.ForegroundColor = DEF_CONSOLE_COLOR;
        }

        public static void printError(string textToPrint)
        {
            printText(textToPrint, ConsoleColor.Red);
        }

        public static void printError(string textToPrint, int printSpeed)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            printText(textToPrint, printSpeed);
            Console.ForegroundColor = DEF_CONSOLE_COLOR;
        }
    }
}

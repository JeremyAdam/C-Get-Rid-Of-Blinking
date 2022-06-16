using System;
using System.Threading;
using Windows.UI.Core;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Console;
using System.IO;

namespace ConsoleApplication1
{
    class MainClass
    {
        // https://stackoverflow.com/questions/7482360/replace-with-in-a-string-in-c-sharp
        // https://stackoverflow.com/questions/888533/how-can-i-update-the-current-line-in-a-c-sharp-windows-console-app
        static void Main(string[] args)
        {
            string[] one = { "1", "2", "3", "4", "5", "6" };
            string[] two = { "7", "8", "9", "10", "11", "12" };
            for (int i = 0; i < one.Length; ++i)
            {
                Console.Write("\r{0}%   ", one[i]);
                Console.WriteLine("");
                Thread.Sleep(30);
            }
            Console.ReadKey(true);
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < two.Length; ++i)
            {
                Console.Write("\r{0}%   ", two[i]);
                Console.WriteLine("");
                Thread.Sleep(30);
            }
            Console.ReadKey(true);
        }

        public class ConsoleSpinner
        {
            int counter;

            public void Turn()
            {
                counter++;
                switch (counter % 4)
                {
                    case 0: Console.Write("a"); counter = 0; break;
                    case 1: Console.Write("s"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }


}
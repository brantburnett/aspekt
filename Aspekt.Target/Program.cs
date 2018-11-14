﻿using Aspekt.Logging;
using System;

namespace Aspekt.Target
{
    class Program
    {
        [Log]
        void Foo()
        {
            LogAttribute la = new LogAttribute();
            la.OnEntryLevel = Levels.Debug;
        }

        static void Main(string[] args)
        {
            while (true)
            {

                Application.Test("Object", typeof(Program), 15, Application.Choice.No);
                var k = Console.ReadKey();
                if (k.Key == ConsoleKey.Q)
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

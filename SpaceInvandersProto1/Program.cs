using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SpaceInvandersProto1
{
    class Program

    {
        enum State
        {
            Menu,
            Settings,
            Gameplay,
            High_Score,
            Exit,
        }
        enum DifficultLevel
        {
            Low,
            Medium,
            High,
        }
        static void Main(string[] args)
        {
            State screen = State.Menu;

            Console.WriteLine("-----Start Menu-----");
            Console.WriteLine("");
            Console.WriteLine("\n 1: Play Game");
            Console.WriteLine("\n 2: Settings");
            Console.WriteLine("\n 3: High Scores");
            Console.WriteLine("\n 4: Exit");

            Console.WriteLine("Waiting for input$ ");
            Console.SetCursorPosition(0, Console.WindowLeft);
            string input = Console.ReadLine();

            //input check
            byte choice;
            bool found_term = Byte.TryParse(input, out choice);
            while (!found_term || !(choice >= 1 && choice <= 4))
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Not a valid input");
                Console.Write("Enter first term: ");
                found_term = Byte.TryParse(Console.ReadLine(), out choice);
            }

            if (choice >= 1 && choice <= 4)
            {
                switch (choice)
                {
                    case 1:
                        screen = State.Gameplay;
                        break;
                    case 2:
                        screen = State.Settings;
                        break;
                    case 3:
                        screen = State.High_Score;
                        break;
                    case 4:
                        screen = State.Exit;
                        System.Environment.Exit(0);
                        break;
                }
            }
            Console.WriteLine(screen);
        }
    }
}
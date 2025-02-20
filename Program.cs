﻿using ConsoleTableExt;

namespace app
{ 
    class Program
    {
        static void Main()
        {
            Console.Title = "Console 🔥";

            textArt.Welcome();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("+--------------------+");
                Console.WriteLine("|     Main Menu      |");
                Console.WriteLine("| Add Task       [A] |");
                Console.WriteLine("| Update Task    [U] |");
                Console.WriteLine("| Delete Task    [D] |");
                Console.WriteLine("| List Tasks     [R] |");
                Console.WriteLine("| Close System   [X] |");
                Console.WriteLine("+--------------------+");

                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "a":
                        Task.AddTask();
                    break;

                    case "x":
                        Console.WriteLine("");
                        exit = true;
                        break;
                }


            }

            textArt.Bye();
        }
    }
}

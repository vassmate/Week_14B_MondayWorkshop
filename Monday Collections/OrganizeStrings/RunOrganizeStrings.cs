using System;
using System.Collections.Generic;

namespace Workshop_Week14b
{
    class RunOrganizeStrings
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            
            Console.WriteLine(">Press ESC to stop adding strings!");
            Console.WriteLine(">Write something below.");
            do
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                stringList.Add(input);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            stringList.Sort();

            Console.Write(">Sorted strings: ");
            foreach (string stuff in stringList)
            {
                Console.Write(stuff + ",");
            }

            Console.WriteLine();
            Console.WriteLine(">Press any key to exit...");
            Console.ReadKey();
        }
    }
}

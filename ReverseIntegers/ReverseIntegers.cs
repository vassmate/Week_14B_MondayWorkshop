using System;
using System.Collections.Generic;

namespace ReverseIntegers
{
    class ReverseIntegers
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            Console.WriteLine(">Press (ESC) to stop adding strings!");
            Console.WriteLine(">Write something below.");

            do
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                numberList.Add(int.Parse(input));
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            numberList.Sort();
            
            Stack<int> reversedNumberStack = new Stack<int>();
            foreach (int i in numberList)
            {
                reversedNumberStack.Push(i);
            }
            
            while(reversedNumberStack.Count > 0)
            {
                object obj = reversedNumberStack.Pop();
                Console.WriteLine(" >From stack: {0}", obj);
            }
            
            Console.WriteLine(">Press any key to exit...");
            Console.ReadKey();
        }
    }
}

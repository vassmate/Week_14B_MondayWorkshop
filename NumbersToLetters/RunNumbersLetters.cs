using System;
using System.Collections.Generic;

namespace NumbersToLetters
{
    class RunNumbersLetters
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> numbersLetters = new Dictionary<int, string>();
            numbersLetters[0] = "Zero";
            numbersLetters[1] = "One";
            numbersLetters[2] = "Two";
            numbersLetters[3] = "Three";
            numbersLetters[4] = "Four";
            numbersLetters[5] = "Five";
            numbersLetters[6] = "Six";
            numbersLetters[7] = "Seven";
            numbersLetters[8] = "Eight";
            numbersLetters[9] = "Nine";

            Console.WriteLine(">Write some numbers below:");
            Console.Write("> ");
            try
            {
                string numbersFromConsole = Console.ReadLine();
                foreach (char digit in numbersFromConsole)
                {
                    int number = int.Parse(digit.ToString());
                    if (numbersLetters.ContainsKey(number))
                    {
                        Console.Write(numbersLetters[number] + "-");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine(">Press any key to exit...");
            Console.ReadKey();
        }
    }
}

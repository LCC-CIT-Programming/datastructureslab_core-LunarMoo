using System;
using System.Collections.Generic;

namespace BinaryNumbersQueue
{
    class Program
    {
        /*
        Using the Visual Studio Solution provided in the starting
        files as a starting point, write an application that asks
        the user to enter a positive integer from the keyboard
        and prints the binary numbers from 1 to that number.
        Use a queue to generate the binary numbers.
        In mathematics and digital electronics, a binary
        number is a number expressed in the base-2 numeral
        system or binary numeral system, which uses only two
        symbols: typically "0" (zero) and "1" (one).
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many Binary numbers you want to see");
            int n = int.Parse(Console.ReadLine());

            Queue<string> que = new Queue<string>();

            que.Enqueue("1");
            for (int i = 0; i < n; i++)
            {
                string nexNum = que.Dequeue();
                Console.WriteLine(nexNum);
                que.Enqueue(nexNum + "0");
                que.Enqueue(nexNum + "1");
            }
        }
    }
}

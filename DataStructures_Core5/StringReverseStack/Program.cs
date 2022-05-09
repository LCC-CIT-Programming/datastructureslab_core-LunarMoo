using System;
using System.Collections.Generic;

namespace StringReverseStack
{
    class Program
    {
        //Using the Visual Studio Solution provided in the starting files as a
        //starting point, write an application that asks the user to enter a
        //string from the keyboard and prints the string in reverse order.
        //Use a stack to reverse the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");

            string words = Console.ReadLine();

            Stack<char> sWords = new Stack<char>();

            foreach(char c in words)
            {
                sWords.Push(c);
                //Console.WriteLine(c);
            }
            int count = sWords.Count;
            for(int i = 0; i < count; i++)
            {
                char c;
                c = sWords.Pop();

                Console.WriteLine(c);
            }


        }
    }
}

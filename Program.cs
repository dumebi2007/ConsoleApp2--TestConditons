﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
            
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            Console.WriteLine("The answer is " + count);
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
            Console.WriteLine("Testing Githut commit");
            
        }
    }
}

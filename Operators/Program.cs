﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;
            ////int y = x++;
            //int y = x;
            //x++;
            //Console.WriteLine($"Using x++, x is {x} and y is {y}");
            //// Using x++, x is 4 and y is 3

            //x = 3;
            ////y = ++x;
            //x++;
            //y = x;
            //Console.WriteLine($"Using ++x, x is {x} and y is {y}");
            //// Using ++x, x is 4 and y is 4

            //Console.WriteLine("Don't do this!");
            //x = 3;
            ////y = ++x - x++;
            //x++;
            //int z = x;
            //y = z - x;
            //x++;
            //Console.WriteLine($"++x - x++ gives: x is {x} and y is {y}");
            //// ++x - x++ gives: x is 5 and y is 0

            //x = 3;
            ////y = x++ - ++x;
            //z = x;
            //x += 2;
            //y = z - x;
            //Console.WriteLine($"x++ - ++x gives: x is {x} and y is {y}");
            //// x++ - ++x gives: x is 5 and y is -2
            //----------------- Using Modulo or Remainder Operator---------
            //int x = 12; 
            //int y = 4;
            //if (x % y == 0)
            //{
            //    Console.WriteLine($"{y} divides exactly into {x}");
            //}
            //else
            //{
            //    Console.WriteLine($"{y} does not divide exactly into {x}");
            //}
            //for (int month = 1; month <= 12; month++)
            //{
            //    Console.WriteLine($"The next month after {month} is {month % 12 + 1}");
            //}
            //----------120 Realtional & Conditional Operators-----------
            int second = 31;
            int minute = 1;

            if ((minute < 59) && ((second + 1) > 59))
            {
                minute++;
            }
        }
    }
}
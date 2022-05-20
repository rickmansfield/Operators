using System;

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
            //int second = 31;
            //int minute = 1;

            //if ((minute < 59) && ((second + 1) > 59))
            //{
            //    minute++;
            //}
            //----------121 Short Circut Eval-----------------
            // the code below is not desiged to evaluate correctly. It's only designed to demonstate "short circuting"
            //    int a = 12;
            //    int b = 6;
            //    //if (b != 0)
            //    //{

            //    //    int c = DivideTwoNumbers(a, b);
            //    //    if (c == 2)
            //    //    {
            //    //        Console.WriteLine("We've found a 2");
            //    //    }
            //    //}
            //    if (b != 0 && DivideTwoNumbers(a, b) == 2)// This proves that the second code after && is not evealuated or short circuted.  
            //    {
            //        Console.WriteLine("We've found a 2");
            //    }
            //    if (b == 0 || DivideTwoNumbers(a, b) == 2)// This proves that the second code after "||" is not evealuated or "short circuted. 
            //    {
            //        Console.WriteLine("We've found a 2");
            //    }
            //}
            //static int DivideTwoNumbers(int x, int y)
            //{ return x / y; }
            int x = 12;
            x *= 34;
            Console.WriteLine(x);

            int y = 12;
            y = y * 34;
            Console.WriteLine(y);
            int z = y -= 8;
            Console.WriteLine($"y is {y} z is {z}");
        }
    }
}
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = 7 + 3 * 4;
            //Console.WriteLine(answer);

            //double radius = 12;
            //double area = Math.PI * radius * radius;

            int x = 3;
            int y = x++;
            Console.WriteLine($"Using x++, x is {x} and y is {y}");
        }
    }
}

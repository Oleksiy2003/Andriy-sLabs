using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);

            char first, second, third;

            first = Convert.ToChar(Console.ReadLine());
            second = Convert.ToChar(Console.ReadLine());
            third = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("You enter:"+first+", "+second+", "+third);

            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 0) Console.WriteLine("Negative");
            else Console.WriteLine("Positive");
            if(y<0) Console.WriteLine("Negative");
            else Console.WriteLine("Positive");

        }
    }
}

using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int age;
            string name;
            double r,l,S,pi,V;
            pi = 3.14;

            Console.WriteLine(a*a + "\n"+a*4);
            Console.WriteLine("-------------------------");
            Console.WriteLine("What is you name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, "+name+"?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age = "+age+"  Name = "+name);
            Console.WriteLine("-------------------------");

            r = Convert.ToDouble(Console.ReadLine());

            l = 2 * pi * r;
            S = pi * r * r;
            V = (4 / 3) * pi * r * r * r;

            Console.WriteLine(l);
            Console.WriteLine(S);
            Console.WriteLine(V);

        }       
    }
}

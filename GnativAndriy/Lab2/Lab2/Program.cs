using System;
using System.Net;


namespace Lab2
{
    public enum Marks
    {
             Boxer,
             Bulldog,
             Doberman,
        germanShepherd

    }
    public enum HttpsStatusCode {
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound
    };
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;
    }
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TASK A,B");

            double[] nums = new double[3];
            double min = 0,
            max = 0;

            int numberOfExeption;
            Console.WriteLine("TASK B");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToDouble(Console.ReadLine());
                if (nums[i] < -5 && nums[i] > 5)
                {
                    Console.WriteLine("Please enter numbers between [-5;5]");

                }
                else
                {

                    min = nums[0];
                    max = nums[0];
                    if (min > nums[i]) min = nums[i];
                    if (max < nums[i]) max = nums[i];
                }
            }

            Console.WriteLine(min + " " + max);
            Console.WriteLine("TASK V");
            numberOfExeption = Convert.ToInt32(Console.ReadLine());
            switch (numberOfExeption)
            {
                case 400:Console.WriteLine(HttpsStatusCode.BadRequest);
                    break;
                case 401:
                    Console.WriteLine(HttpsStatusCode.Forbidden);
                    break;
                case 402:
                    Console.WriteLine(HttpsStatusCode.NotFound);
                    break;
                case 403:
                    Console.WriteLine(HttpsStatusCode.PaymentRequired);
                    break;
                case 404:
                    Console.WriteLine(HttpsStatusCode.Unauthorized);
                    break;
                default:
               
                    Console.WriteLine("Enter number between [400;404]");
                    break;
            }
            Console.WriteLine("TASK C");
            Dog Ralf;
            Ralf.Name = Console.ReadLine();
            Ralf.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose:"+Marks.Boxer+" "+Marks.Bulldog+" "+Marks.Doberman);
            Ralf.Mark = Console.ReadLine();
            Console.WriteLine(Ralf.Name);
            Console.WriteLine(Ralf.Age);
            Console.WriteLine(Ralf.Mark);
        }
    }
}
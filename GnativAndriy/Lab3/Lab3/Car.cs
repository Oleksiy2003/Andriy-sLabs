using System;
namespace Lab3
{
    public class Car
    {
        public string NameOfCar;
        public string ColorOfCar;
        public double Price;
        const string CompanyName = "Volkswagen";

        public Car(string name, string color, double price)
        { 

        }
        public Car()
        {

        }
        public void Input(string name, string color, double price)
        {
            name = Console.ReadLine();
            NameOfCar = name;
            color = Console.ReadLine();
            ColorOfCar = color;
            price = Convert.ToDouble(Console.ReadLine());
            Price = price;
            
        }
        public void Print(string name, string color, double price)
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
            
        }
        public void ChangePrice(double x)
        {
            double calc = x / 10;
            x -= calc;
            Price = x;
        }
        public void ChangeColor(string color)
        {
            color = Console.ReadLine();
            ColorOfCar = color;
        }
    }
}
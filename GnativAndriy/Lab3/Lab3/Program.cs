using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;
            string color;
            double price;
            Car car1 = new Car();
           car1.Input(car1.NameOfCar,car1.ColorOfCar,car1.Price);
            car1.ChangePrice(car1.Price);
            car1.ChangeColor(car1.ColorOfCar);
            car1.Print(car1.NameOfCar, car1.ColorOfCar, car1.Price);

            Car car2 = new Car();
            car2.Input(car2.NameOfCar, car2.ColorOfCar, car2.Price);
            car2.ChangePrice(car2.Price);
            car2.Print(car2.NameOfCar, car2.ColorOfCar, car2.Price);

          
            if (car1.Price == car2.Price && car1.NameOfCar == car2.NameOfCar) Console.WriteLine("Equal");
            else return;
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class PrintObject
    {
        public static void PrintCar(Car car)
        {
            Console.WriteLine($"The model of the car is: {car.Make}");
            Console.WriteLine($"The make of the car is: {car.Model}");
            Console.WriteLine($"The year of the car is: {car.Year}");
        }
    }
}

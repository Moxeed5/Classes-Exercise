using System.Diagnostics;

namespace Classes
{
    public class Program
    {

        //Create a new instance of the Car class
        //Set values in the properties for the object
        //Print the values of each property to the Console
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "Volvo";
            car1.Model = "240";
            car1.Year = 1993;

            PrintObject.PrintCar(car1);
        }
    }
}

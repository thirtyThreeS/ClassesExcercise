using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BasicClasses Exercise

//Create a new C# .Net Core Console App 
//Create a class named Car - make sure it is public
//In the Car class,
//Create a Make property of type string that is public
//Create a Model property of type string that is public
//Create a Year property of type int that is public
//In the Main method,
//Create a new instance of the Car class
//Set values in the properties for the object
//Print the values of each property to the Console



namespace ClassesCSharp
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Toyota";
            car.Model = "Corola";
            car.Year = 2022;

            Console.WriteLine($"My brand-new {car.Year} {car.Make} {car.Model} gets 40mpg!!");
                
        }
    }
}
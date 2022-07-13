using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public class Car
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public static string Make { get; set; }
        public static string Model { get; set; }
        public static int Year { get; set; }

        public static void Cars()
        {
            Console.WriteLine(Make = "Dodge");
            Console.WriteLine(Model = "Challenger");
            Console.WriteLine(Year = 2018);
        }
    }
}

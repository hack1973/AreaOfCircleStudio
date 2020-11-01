using System;

namespace AreaOfCircleStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double mpg;
            double area;
            double circumference;
            double diameter;
            double gallons;

            Console.WriteLine("Enter a radius of a circle: ");
            string userRadius = Console.ReadLine();
            radius = double.Parse(userRadius);

            Console.WriteLine("How many MPG does your car get: ");
            string userMpg = Console.ReadLine();
            mpg = double.Parse(userMpg);

            area = Math.PI * Math.Pow(radius,2);
            circumference = 2 * Math.PI * radius;
            diameter = 2 * radius;
            gallons = radius / mpg;

            Console.WriteLine("\nThe area of a circle with a radius of " + radius + " is " + area);
            Console.WriteLine("The circumference of a circle with a radius of " + radius + " is " + circumference);
            Console.WriteLine("The diameter of a circle with a radius of " + radius + " is " + diameter);
            Console.WriteLine("You would use " + gallons + " gallons of gas if you drove the radius of " + radius + " miles getting " + mpg + " miles to the gallon.");
        }
    }
}

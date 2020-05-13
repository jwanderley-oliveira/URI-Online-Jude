using System;
using System.Globalization;

namespace _1002_uri_area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

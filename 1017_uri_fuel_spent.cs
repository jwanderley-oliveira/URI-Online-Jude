using System;
using System.Globalization;

namespace _1017_uri_fuel_spent
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int time, velocity, distance;
            double liters;

            time = int.Parse(Console.ReadLine());
            velocity = int.Parse(Console.ReadLine());

            distance = time * velocity;

            // Neste ponto deve-se adicionar o .0 ou realizar o casting (double)

            liters = distance / 12.0;

            Console.WriteLine(liters.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

using System;
using System.Globalization;

namespace _1008_uri_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number, times;
            double hourValue, salary;

            number = int.Parse(Console.ReadLine());
            times = int.Parse(Console.ReadLine());

            hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hourValue * times;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
            
        }
    }
}

using System;

namespace _1004_uri_simple_product
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int x, y, prod;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            prod = x * y;

            Console.WriteLine("PROD = " + prod);

            Console.ReadLine();
        }
    }
}

using System;

namespace MultiplesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beder brugeren om at indtaste dividend
            Console.WriteLine("Enter dividend");
            double dividend = double.Parse(Console.ReadLine());

            // Beder brugeren om at indtaste divisor
            Console.WriteLine("Enter divisor");
            double divisor = double.Parse(Console.ReadLine());

            // Brug modulo til at tjekke, om dividend er et multiplum af divisor
            if (dividend % divisor == 0)
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("Not multiples");
            }
        }
    }
}
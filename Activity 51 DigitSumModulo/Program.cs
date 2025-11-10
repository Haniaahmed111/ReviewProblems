using System;

namespace DigitSumModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Læs et heltal fra brugeren
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            // Så længe tallet er større end 0
            while (number > 0)
            {
                int remainder = number % 10; // Få sidste ciffer
                sum += remainder;            // Læg det til summen
                number /= 10;                // Fjern sidste ciffer
            }

            // Udskriv resultatet
            Console.WriteLine("Sum: " + sum);
        }
    }
}
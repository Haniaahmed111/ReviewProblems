using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Læs to heltal fra brugeren
            Console.WriteLine("Enter first integer");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer");
            int second = int.Parse(Console.ReadLine());

            // Beregn resultater
            int sum = first + second;
            int product = first * second;
            int difference = first - second;
            int quotient = first / second;
            int remainder = first % second;

            // Udskriv resultater
            Console.WriteLine("Result:");
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(difference);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
        }
    }
}
using System;

namespace DigitSumForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beder brugeren om at indtaste et heltal
            Console.WriteLine("Enter an integer");
            string input = Console.ReadLine();

            int sum = 0;

            // Løber igennem hvert tegn i input-strengen
            foreach (char c in input)
            {
                // Konverter hvert tegn til string og derefter til et heltal
                int digit = int.Parse(c.ToString());
                sum += digit;
            }

            // Udskriv resultatet
            Console.WriteLine("Sum: " + sum);
        }
    }
}
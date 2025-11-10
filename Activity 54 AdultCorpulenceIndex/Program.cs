using System;

namespace AdultCorpulenceIndex
{
    class Program
    {
        // Funktion til at beregne Corpulence Index (CI)
        static double ci(double mass, double height)
        {
            return mass / Math.Pow(height, 3);
        }

        static void Main(string[] args)
        {
            // Konstanter for CI-kategorier
            const double underWeightMax = 11;
            const double normalWeightMax = 14;
            const double overWeightMax = 18;
            const double obeseMax = 22;

            // Input fra brugeren
            Console.WriteLine("Enter mass in kg");
            double mass = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height in m");
            double height = double.Parse(Console.ReadLine());

            // Beregn CI
            double ciValue = Math.Round(ci(mass, height), 2);
            string category;

            // Brug if-else til at bestemme kategori
            if (ciValue < underWeightMax)
                category = "underweight";
            else if (ciValue < normalWeightMax)
                category = "normal";
            else if (ciValue < overWeightMax)
                category = "overweight";
            else if (ciValue < obeseMax)
                category = "obese";
            else
                category = "very obese";

            // Udskriv resultat
            Console.WriteLine($"Adults corpulence index of {ciValue} means: {category}");
        }
    }
}
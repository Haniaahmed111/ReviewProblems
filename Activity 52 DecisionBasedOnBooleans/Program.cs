using System;

namespace DecisionBasedOnBooleans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spørgsmål 1
            Console.WriteLine("Is the lecture topic interesting?");
            char topic = char.Parse(Console.ReadLine().ToLower());

            // Spørgsmål 2
            Console.WriteLine("Does one of your friends join?");
            char friend = char.Parse(Console.ReadLine().ToLower());

            // Spørgsmål 3
            Console.WriteLine("Do you have problems with the assignment?");
            char problem = char.Parse(Console.ReadLine().ToLower());

            // Betingelse: du går kun, hvis emnet er interessant,
            // og (enten en ven deltager ELLER du har problemer med opgaven)
            if (topic == 'y' && (friend == 'y' || problem == 'y'))
            {
                Console.WriteLine("Go. ✅");
            }
            else
            {
                Console.WriteLine("Stay. ❌");
            }
        }
    }
}
using System;

namespace SentenceFromWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words of a sentence one by one including punctuation:");

            string sentence = "";
            string word;

            // Læs ord ét ad gangen indtil brugeren skriver et ord med punktum
            do
            {
                word = Console.ReadLine();
                sentence += word + " ";
            }
            while (!word.EndsWith("."));

            // Udskriv den samlede sætning
            Console.WriteLine(sentence.Trim());
        }
    }
}
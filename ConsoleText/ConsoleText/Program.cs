namespace ConsoleText
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            string text = "Hello World";
            ConsoleColor originalColor = Console.ForegroundColor;

            foreach (char letter in text)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(letter);
                Thread.Sleep(200); // Wacht 200 milliseconden tussen elke letter
            }

            Console.ForegroundColor = originalColor; // Herstel de oorspronkelijke kleur
            Console.WriteLine(); // Voeg een nieuwe regel toe na het weergeven van de tekst
        }
    }
}
using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for a phrase, stores it in a string
            Console.WriteLine("Insert a phrase.");
            string Input = Console.ReadLine();

            //asks for a char, stores it in a string
            Console.WriteLine("\nWrite the character you want to remove from the phrase you wrote.");
            string Char = Console.ReadLine();

            //convert the string that stores the char into a char type variable.
            char InputChar = Convert.ToChar(Char[0]);

            //for each letter in the phrase
            foreach (char c in Input)
            {
                //if the letter is not the same as the char it prints it
                if (c != InputChar)
                {
                    Console.Write(c);
                }
            }
            Console.ReadLine();
        }
    }
}

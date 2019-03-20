using System;

namespace ChatBot
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            while (true)
            {
                
                if (i == 0)
                {
                    Console.WriteLine("What do you need human?");
                    i++;
                }
                else
                {
                    Console.WriteLine("\n\nWhat else do you need human?");
                }
                string UserInput = Console.ReadLine();

                if (UserInput == "Hello" || UserInput == "hello")
                {
                    string Answer = "Hello Human";
                    Console.WriteLine(Answer);
                }
                else if (UserInput == "Who are you?" || UserInput == "who are you?" || UserInput == "Who are you" || UserInput == "who are you")
                {
                    string Answer = "I am a program designed to answer your kind";
                    Console.WriteLine(Answer);
                }
                else if (UserInput == "what's your name?")
                {
                    string Answer = "My name is BT-7274";
                    Console.WriteLine(Answer);
                }
            }
        }
    }
}

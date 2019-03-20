using System;

namespace piramide
{
    class Program
    {
        static void Main()
        {
            int lines = 4;
            int center = 110;
            bool up = true;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetBufferSize(1920, 1080);
            Console.Title = "haaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowPosition(0, 0);
            while (true)
            {
                
                if (lines == 20)
                {
                    up = false;
                }
                else if (lines == 2)
                {
                    up = true;
                }

                
                
                if (up)
                {
                    lines++;
                    center--;
                }
                else
                {
                    lines--;
                    center++;
                }
                //string input = Console.ReadLine();
                //int lines = Convert.ToInt32(input);
                
                for (int x = 0; x <= lines; x++)
                {
                    int j = lines - x;
                    int b = x;
                    for (int z = 0; z < center; z++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < j; y++)
                    {
                        Console.Write(" ");
                    }
                    for (int y = 0; y < b; y++)
                    {
                        Console.Write(" ");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}

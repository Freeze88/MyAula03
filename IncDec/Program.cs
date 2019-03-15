using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int c = 0;

            --c;
            i++;
            Console.WriteLine("{0} {1}", i, c);

            Console.ReadKey();
        }
    }
}

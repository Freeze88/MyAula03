using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            string Lenght = Console.ReadLine();
            string Height = Console.ReadLine();

            int L = Convert.ToInt32(Height);
            int H = Convert.ToInt32(Lenght);

            int[,] matrix = new int [L,H];

            for (int j = 0; j < matrix.GetLength(0); j ++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    string Number = Console.ReadLine();
                    int n = Convert.ToInt32(Number);

                    matrix[i,j] = n;
                }
            }

            for (int z = 0; z < matrix.GetLength(0); z++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                        Console.Write(matrix[z, x] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}

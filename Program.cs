using System;

namespace starDecreasingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            for (row = 1; row <= 6; row++)
            {
                for (col = 6; col >= row; col--)
                {
                    Console.Write("*"+" ");

                }
                Console.WriteLine(" ");
            }
        }
    }
}

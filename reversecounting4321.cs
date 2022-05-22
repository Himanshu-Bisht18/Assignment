using System;

namespace reverseCounting4321
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            for(row=1; row<=4;row++)
            {
                for (col=5-row; col>=1; col--)
                {
                    Console.Write(col+ " ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}

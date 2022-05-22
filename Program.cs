using System;

namespace reverseCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;

             for(row=1; row<=5; row++)
            {
                for (col = 6 - row; col >=1; col--)
                {
                    Console.Write(col + " ");
                }
                
                Console.WriteLine(" ");
            }
        }
    }
}
                
                 

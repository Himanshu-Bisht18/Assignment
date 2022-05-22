using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        { int col, row;
            for (row = 1; row <= 4 ; row++)
            {
                for ( col =1; col<=row; col++)
                {
                 
                     Console.Write(col + " ");
                }
                Console.WriteLine("");

            }
           
        }
         
    }
}

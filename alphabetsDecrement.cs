using System;

namespace alphabetsDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            
            for(row=5; row>=1; row--)
            {   
                for(col=1; col<=row;col++)
                {
                    Console.Write(Convert.ToChar(96+col)+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}

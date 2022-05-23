using System;

namespace CountingwithStarsAtdiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, row;
            for(row=1; row<=5; row++)
            {
                for(col=1; col<=5; col++)
                { if(col==row)
                    {
                        Console.Write("*"+" ");
                    }
                else
                    {

                    Console.Write(col + " ");
                    }
                }
                Console.WriteLine(" ");
            }
          
        }
    }
}

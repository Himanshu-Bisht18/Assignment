
using System;

namespace abbreviatedFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int i = 0;
            Console.WriteLine("Enter any name: ");
            name = Console.ReadLine();
            char[] letters = name.ToCharArray();
            Console.Write(letters[0] + ". ");
            for (i = 0; i < letters.Length - 1; i++)
            {
                if ( letters[i] ==' ')
                {
                    Console.Write(letters[i + 1] + ". ");
                }
            }
        
                     

           
            
            




        }
    }
}
        
       

            
       


      


            




      



 


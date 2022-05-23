using System;

namespace reverseOrderOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,remainder, reverseNumber=0;
            Console.Write("Enter any number to get reverse: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number /= 10;
            }
            Console.Write("Reversed Number: " + reverseNumber);
             
             
            
            
        }   
    }
}

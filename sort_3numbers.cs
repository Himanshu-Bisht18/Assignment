using System;

namespace sort_3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting of three numbers");
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2 || number1 == number3)
            {
                Console.WriteLine("Provide three different numbers");
            }
            else if (number1 < number2 && number2 < number3 && number2 < number3)
            {
                Console.WriteLine($"sorted order of numbers is:{number1},{number2},{number3}");
            }


            else if (number2 < number3 && number2 < number1 && number3 < number1)

            {
                Console.WriteLine($"sorted order of numbers is:{number2},{number3},{number1}");
            }
            else
            {
                Console.WriteLine($"sorted order of numbers is:{number3},{number1},{number2}");
            }

        }

    }

}












        
     
 

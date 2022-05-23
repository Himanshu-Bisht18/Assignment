using System;

namespace smallest_number_among_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine($"Among numbers given above, {number1} is the smallest");
            }
            else if (number2 < number3 && number2 < number1)
            {
                Console.WriteLine($"Among numbers given above, {number2} is the smallest");
            }
            else
            {
                Console.WriteLine($"Among numbers given above, {number3} is the smallest");

            }
            


        }

    }
}

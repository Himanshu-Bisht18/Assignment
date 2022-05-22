using System;

namespace OccurenceOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];


            for(int i=0;i<10;i++)

            {
                Console.WriteLine($"Enter {i+1} number of array : ");
                numbers[i] = int.Parse(Console.ReadLine());
               
            }
            Console.Write($"Numbers of array are :");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
                Console.Write(" ");
            }

            Console.WriteLine("Enter number to check occurrence  :  ");
            int number = Convert.ToInt32(Console.ReadLine());
            int occurs = 0;
            for (int j = 0; j<= numbers.Length - 1; j++)
            {
                if ( number== numbers[j] )
                {
                    occurs++;
                }
            }

            Console.WriteLine($"occurrence of {number} in the given array is {occurs}");

            Console.ReadKey();

        }
    }
}





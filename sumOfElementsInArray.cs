using System;

namespace sumOfElementsOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            int[] numbers = new int[10];
            for(i=0;i<10;i++)
            {
                Console.WriteLine($"Enter element {i+1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("First stored number is : " +numbers[i]);
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of {i} stored in array is : {sum}");
        }
    }
}

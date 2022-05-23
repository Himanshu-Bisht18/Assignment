using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter any number from 0 t0 6");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("You have choosen Sunday");
                    break;
                case 1:
                    Console.WriteLine("You have choosen Monday");
                    break;
                case 2:
                    Console.WriteLine("You have choosen Tuesday");
                    break;
                case 3:
                    Console.WriteLine("You have choosen Wednesday");
                    break;
                case 4:
                    Console.WriteLine("You have choosen Thursday");
                    break;
                case 5:
                    Console.WriteLine("You have choosen Friday");
                    break;
                case 6:
                    Console.WriteLine("You have choosen Saturday");
                    break;
                default:
                    Console.WriteLine("Wrong choice, choose between 0 to 6");
                    Console.WriteLine(" ");
                  
                    goto start;
                       
            }
        }
    }
}

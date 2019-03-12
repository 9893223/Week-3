using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double apples = 1.25;
            double bananas = 3.15;
            double kiwifruit = 4.25;
            double oranges = 2.75;
        
            Console.WriteLine("Please enter one of the follwing fruits to check the price per kilo: (Apples / Bananas / Kiwifruit / Oranges");
            string fruit = Console.ReadLine().ToLower();

            switch (fruit)
            {
                case "apple":
                case "apples":
                    Console.WriteLine("Apples are" + " " + '$' + 1.25 + " " +  "per kilo");
                    break;

                case "banana":
                case "bananas":
                    Console.WriteLine("Bananas are" + " " + '$' + 3.15 + " " + "per kilo");
                    break;


                case "kiwifruit":
                    Console.WriteLine("Kiwifruit are" + " " + '$' + 4.25 + " " + "per kilo");
                    break;

                case "orange":
                case "oranges":
                    Console.WriteLine("Oranges are" + " " + '$' + 2.75 + " " + "per kilo");
                    break;

                    default:
                    Console.WriteLine("There was an error");
                    break;


            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title//
            Console.WriteLine();
            int start = 3;
            int finish = 7;

            for(int i = 3; i <= finish; i++)
            {
                Console.WriteLine($" {i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }

            int counter = 3;
            finish = 7;
            while (counter <= finish)
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}"); counter++;
            }

            counter = 3;
            do
            {

                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}"); counter++;

            } while (counter <= finish);


            Console.ReadLine();
        }
    }
}

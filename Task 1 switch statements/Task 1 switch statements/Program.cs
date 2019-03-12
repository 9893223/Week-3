using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Guess what type of bird is my favourite: (i.e Pigeon, Dove, Sparrow");
             string bird = Console.ReadLine().ToLower();

            switch (bird)
            {
                case "dove":
                    Console.WriteLine("You guessed correctly");
                    break;

                default:
                    Console.WriteLine("Nope, please try again");
                    break;

            }
            Console.ReadLine();
            }

        }
    }


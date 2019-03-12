using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number:");
            int num2 = int.Parse(Console.ReadLine());

            int result;

            Console.WriteLine("Select a calculation method for these two numbers from the following options (input the symbol) \n+ \n- \n* \n/");
            char method = char.Parse(Console.ReadLine());

            switch (method)
            {

                case '+':
                    result = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                    break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                    break;

                default:
                    Console.WriteLine("Not recognised");
                    break;



            }
            Console.ReadLine();


        }
    }
}

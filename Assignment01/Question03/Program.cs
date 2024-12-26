using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number -> ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number -> ");
            int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Operator -> ");
            //char op = Console.ReadLine()[0];

            double result = 0;
            int choice = 0;

            do
            {
                Console.WriteLine("0.EXIT");
                Console.WriteLine("\n1.ADDTION");
                Console.WriteLine("\n2.SUBTRACTION");
                Console.WriteLine("\n3.MULTIPLICATION");
                Console.WriteLine("\n4.DIVISION");

                Console.WriteLine("\n\n Enter Your Choice - ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Program Ended");
                            return;
                        }
                 

                    case 1:
                        {
                            result = num1 + num2;
                            Console.WriteLine("Addtion = " + result);
                        }
                        break;

                    case 2:
                        {
                            result = num1 - num2;
                            Console.WriteLine("Subtration = " + result);
                        }
                        break;

                    case 3:
                        {
                            result = num1 * num2;
                            Console.WriteLine("Multiplication = " + result);
                        }
                        break;

                    case 4:
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("Division By Zero Is Not Possible");
                                return;
                            }
                            result = num1 / num2;
                            Console.WriteLine("Division" + result);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                }

            }
            while (choice!=0);
        }
    }
}

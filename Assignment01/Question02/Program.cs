using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number -> ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number -> ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator -> ");
            char op = Console.ReadLine()[0];

            double result = 0;

            switch (op)
            {
                case '+':
                    {
                       result=num1 + num2;
                        Console.WriteLine("Addtion = "+result);
                    }
                    break;

                case '-':
                    {
                        result = num1 - num2;
                        Console.WriteLine("Subtration = "+result);
                    }
                    break;

                case '*':
                    {
                        result = num1 * num2;
                        Console.WriteLine("Multiplication = "+result);
                    }
                    break;

                case '/':
                    {
                        if (num2==0)
                        {
                            Console.WriteLine("Division By Zero Is Not Possible");
                            return;
                        }
                        result = num1 / num2;
                        Console.WriteLine("Division"+result);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
            }

       
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");
            Console.WriteLine("Welcome to my Calculator ");
          

            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");

           

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Yor result: {num1} + {num2} =" + result);
                    break;

                default:
                    Console.WriteLine("That was not a vaild option");
                    break;
                    
            }
            

            Console.ReadKey();
            Console.WriteLine("thank you for using MyCalculator");
        }
    }
}

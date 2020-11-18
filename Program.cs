using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculatron
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a calculator object to do operations
            Calculator calc = new Calculator();

            //Prompt for a selection
            Console.WriteLine("Welcome to Calculatron 3000!");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Add two numbers");
                Console.WriteLine("2) Subtract two numbers");
                Console.WriteLine("3) Multiply two numbers");
                Console.WriteLine("4) Divide two numbers");
                Console.WriteLine("5) Square a number");
                Console.WriteLine("6) Find the square root of a number");
                Console.WriteLine("7) Advanced");
                Console.WriteLine("0) Exit");

                int selection = 0;
                //read selection
                try
                {
                    selection = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pleae enter a valid option.");
                    continue;
                }
                

                //if the user entered 1-4, get the two numbers
                if (selection >= 1 && selection <= 4)
                {
                    Console.Write("Please enter two numbers with a space in between: ");
                    int num1 = 0;
                    int num2 = 0;
                    List<string> nums =  Console.ReadLine().Split(" ").ToList();
                    if(nums.Count != 2){
                        Console.WriteLine("Please enter exactly two integers.");
                        continue;
                    }
                    try
                    {
                        num1 = Int32.Parse(nums[0]);
                        num2 = Int32.Parse(nums[1]);
                    }
                    catch
                    {
                        Console.WriteLine("Pleae enter two valid integers.");
                        continue;
                    }

                    //log the appropiate result based on the user's selection
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"The result of adding {num1} and {num2} is {calc.Add(num1, num2)}");
                            break;
                        case 2:
                            Console.WriteLine($"The result of subtracting {num1} and {num2} is {calc.Subtract(num1,num2)}");
                            break;
                        case 3:
                            Console.WriteLine($"The result of multiplying {num1} and {num2} is {calc.Multiply(num1,num2)}");
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine($"The result of dividing {num1} and {num2} is {calc.Divide(num1, num2)}");
                            }
                            catch
                            {
                                Console.WriteLine("Can't divide by 0");
                            }
                            break;
                    }
                }
                //if the user picked 5 or 6 only read one number
                else if(selection == 5 || selection == 6)
                {
                    int num = 0;
                    Console.Write("Enter a number: ");
                    try
                    {
                        num = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid integer");
                    }

                    //log the result depending on the user's choice
                    if(selection == 5)
                    {
                        Console.WriteLine($"The sqaure of {num} is {calc.Square(num)}");
                    }
                    else
                    { 
                        double result = calc.Sqrt(num);
                        if(Double.IsNaN(result))
                        {
                            Console.WriteLine($"Can't find the square root of a negative integer");
                        }
                        else
                        {
                            Console.WriteLine($"The square root of {num} is {result}");  
                        }
                         
                    }
                }
                else if(selection == 7)
                {   
                    //get the user formula
                    List<string> formula = Console.ReadLine().Split(" ").ToList();
                    int num1 = 0;
                    int num2 = 0;
                    try
                    {
                        num1 = Int32.Parse(formula[0]);
                        num2 = Int32.Parse(formula[2]);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter valid integers.");
                        continue;
                    }

                    //perform the desired function
                    switch (formula[1])
                    {
                        case "+":
                            Console.WriteLine(calc.Add(num1, num2));
                            break;
                        case "-":
                            Console.WriteLine(calc.Subtract(num1,num2));
                            break;
                        case "*":
                            Console.WriteLine(calc.Multiply(num1, num2));
                            break;
                        case "/":
                            try
                            {
                                Console.WriteLine(calc.Divide(num1, num2));
                            }
                            catch
                            {
                                Console.WriteLine("Can't divide by 0");
                            }
                            break;
                    }
                }
                //if the user entered anything other than 1,2,3, or 4, exit the while loop
                else
                {
                    break;
                }
            }
        }
    }
}

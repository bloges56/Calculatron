using System;

namespace Calculatron
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for a selection
            Console.WriteLine("Welcome to Calculatron 3000!");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Add two numbers");
                Console.WriteLine("2) Subtract two numbers");
                Console.WriteLine("3) Multiply two numbers");
                Console.WriteLine("4) Divide two numbers");
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
                    Console.Write("Please enter the first number: ");
                    int num1 = 0;
                    int num2 = 0;
                    try
                    {
                        num1 = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Pleae enter a valid integer.");
                        continue;
                    }
                    Console.Write("Please enter the second number: ");
                    try
                    {
                         num2 = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Pleae enter a valid integer.");
                        continue;
                    }

                    //log the appropiate result based on the user's selection
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"The result of adding {num1} and {num2} is {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"The result of subtracting {num1} and {num2} is {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"The result of multiplying {num1} and {num2} is {num1 * num2}");
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine($"The result of dividing {num1} and {num2} is {num1 / num2}");
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

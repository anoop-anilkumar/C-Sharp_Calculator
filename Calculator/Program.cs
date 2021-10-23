using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Calculator Console App Using C#");
            Console.WriteLine("-------------------------------\n");
            Console.Write("Enter the first number :     ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the second number :     ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Modulus");
            Console.Write("\nEnter your Choice :    ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"\n The Result of  {num1} + {num2} = " + (num1+num2));
                    break;
                case "2":
                    Console.WriteLine($"\n The Result of  {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"\n The Result of  {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    // Ask the user to enter a non-zero divisor until they do so.
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "5":
                    Console.WriteLine($"\n The Result of  {num1} % {num2} = " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }
}

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Calculator");
            while (true)
            {
                Calculation();

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string again = Console.ReadLine();

                if (again.Equals("Y", StringComparison.OrdinalIgnoreCase) && again.Equals("y", StringComparison.OrdinalIgnoreCase))
                    continue;
                break;
                    
            }
            Console.WriteLine("Thank you for using the calculator!");

        }

        static void Calculation()
        {
            int result = 0;

            Console.WriteLine();
            Console.WriteLine("Enter your first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter your second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Choose your operation");
            Console.WriteLine("Enter (+) for addition, (-) for subtraction, (*) for multiplication, (/) for division, and (%) for modulus");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        Console.WriteLine("Division by zero is not allowed!");
                    break;

                case "%":
                    if (number2 != 0)
                        result = number1 % number2;
                    else
                        Console.WriteLine("Modulus by zero is not allowed!");
                    break;

                default:
                    Console.WriteLine(answer + " is not a valid operation! Please choose +, -, /, *, %");
                    Calculation(); 
                    return; 
            }
            Console.WriteLine();
            Console.WriteLine("The result is: " + result);
        }
    }
}
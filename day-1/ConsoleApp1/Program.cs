using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("welcome to the calcultor");
        Console.WriteLine("Enter the first number ??");
        if(!double.TryParse(Console.ReadLine(),out double num1))
        {
            Console.WriteLine("Not a valid number");
            return;
        }
        
        Console.WriteLine("Enter the second number ??");
        if (!double.TryParse(Console.ReadLine(),out double num2))
        {
            Console.WriteLine("Not a valid number");
        }
        Console.Write("Select an operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0];
        double result = PerformOperation(num1, num2, operation);
        Console.WriteLine($"REsult:- {result}");

    }
    static double PerformOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                // Check for division by zero
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return 0.0;
                }
            default:
                Console.WriteLine("Invalid operation. Please select +, -, *, or /.");
                return 0.0;

        }
    }

}
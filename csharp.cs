// Calculator
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num2 != 0 ? num1 / num2 : double.NaN;
                break;
            default:
                Console.WriteLine("Invalid operator!");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}


// Find Largest Number from Array

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}

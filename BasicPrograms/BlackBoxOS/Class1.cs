using System;

public class CalculatorApp
{
	public StartCalculator()
	{
        int n1, n2, result;
        char operation;
        Console.WriteLine("Hello dear user ");
        Console.WriteLine("Enter your integer ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operation from them (+,-,/,*,%) ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter second integer ");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (operation == '+')
        {
            Console.WriteLine(n1 + n2);

        }
        if (operation == '*')
        {
            Console.WriteLine(n1 * n2);

        }
        if (operation == '/')
        {
            Console.WriteLine(n1 / n2);

        }
        if (operation == '-')
        {
            Console.WriteLine(n1 - n2);

        }
        else
        {
            Console.WriteLine("!!!!Wrong Choise!!!!");
        }

    }
}

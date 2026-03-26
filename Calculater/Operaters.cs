namespace Calculater;

public class Operators
{
    public double Plus(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Minus(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Divide(double num1, double num2)
    {
        return num1 / num2;
    }
    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    public string ChooseOperation(string operation, double num1, double num2,  double result)
    {
        switch (operation)
        {
            case "+": result = Plus(num1, num2); break;
            case "-": result = Minus(num1, num2); break;
            case "*": result = Multiply(num1, num2); break;
            case "/":
                if (num2 != 0) result = Divide(num1, num2);
                else Console.WriteLine("Error: Cannot divide by zero.");
                break;
            default: Console.WriteLine("Invalid operation. Please choose correct operator.('+','-','*','/')"); break;
        }
        return $"{result}";
    }
    public double GetNumberValue(string userPrompt)
    {
        double numericValue;
        Console.Write(userPrompt);
        while (!double.TryParse(Console.ReadLine(), out numericValue))
        {
            Console.Write("Invalid input. Please enter a numeric value: ");
        }
        return numericValue;
    }
}

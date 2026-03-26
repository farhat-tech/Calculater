// See https://aka.ms/new-console-template for more information
using Calculater;

// Loop control variable
bool keepRunning = true; 
//Class object
Operators cases = new Operators();

while (keepRunning)
{
    // Clears the screen for each new calculation
    Console.Clear(); 
    Console.WriteLine("...Basic Console Calculator...");

    double fisrtValue = cases.GetNumberValue("Enter first number: ");
    double secondValue= cases.GetNumberValue("Enter second number: ");
    
    Console.WriteLine("Choose an operation: + , - , * , /");
    string operation = Console.ReadLine();

    double result = 0;

    Console.WriteLine($"Result: {cases.ChooseOperation(operation, fisrtValue, secondValue, result)}");

    // Ask the user if they want to end the program
    Console.WriteLine("\nContinue using calculator? (y/n)");
    string userChoice = Console.ReadLine()?.ToLower();
    if (userChoice != "y")
    {
        // Exit the loop
        keepRunning = false;
        Console.WriteLine("Thanks for using the calculator!");
    }
}
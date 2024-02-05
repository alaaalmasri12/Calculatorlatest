using CalculatorLibrary;
Calculator calculator = new Calculator();
while (true)
{
    int num1 = 0; int num2 = 0;

    // Display title as the C# console calculator app.
    Console.WriteLine("Console Calculator in C#\r");
    Console.WriteLine("------------------------\n");

    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    // Ask the user to choose an option.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("\tr - Remove List");
    Console.WriteLine("\tl - show List");
    Console.WriteLine("\tq - Square Root");

    Console.WriteLine("\te - exit");

    Console.Write("Your option? ");
    var op = Console.ReadLine();
    if(op.ToString().ToLower() == "e")
    {
        break;
    }
    var result = calculator.DoOperation(num1, num2, op);

    // Wait for the user to respond before closing.
    Console.Write("Press any key to close the Calculator console app...");
    Console.ReadKey();
}

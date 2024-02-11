

Console.WriteLine("Hello, welcome to the calculator program");

while(true) {
    try {
        Console.WriteLine("Enter yor first number");

        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter yor second number");

        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter yor operation type (+, -, /, *, %)");

        char operationType = Console.ReadLine().FirstOrDefault();

        double result = Calculator.PerformOperation(num1, num2, operationType);
            
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException) 
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch
    {
        Console.WriteLine("An Exception occurred !!!");
    }
    
    Console.WriteLine("Do you want to do more operations ? (n - no | y - yes)");

    if (Convert.ToChar(Console.ReadLine()) != 'y') break;
}




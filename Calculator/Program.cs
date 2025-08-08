{
    while (true)
    {
        CalculatorMenu();
        string selection = Console.ReadLine();
        if (selection.ToUpper() == "Q")
        {
            Console.WriteLine("Exiting the calculator. Goodbye!");
            break;
        }

        if (!IsValidSelection(selection))
        {
            Console.WriteLine("Invalid selection. Please try again.");
            continue;
        }

        Console.WriteLine("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out double firstNumber))
        {
            Console.WriteLine("Invalid number. Please try again.");
            continue;
        }

        Console.WriteLine("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out double secondNumber))
        {
            Console.WriteLine("Invalid number. Please try again.");
            continue;
        }

        double result = 0;
        string operation = "";
        bool validOperation = true;

        switch (selection)
        {
            case "1":
                result = Add(firstNumber, secondNumber);
                operation = "+";
                break;
            case "2":
                result = Subtract(firstNumber, secondNumber);
                operation = "-";
                break;
            case "3":
                result = Multiply(firstNumber, secondNumber);
                operation = "*";
                break;
            case "4":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                else
                {
                    result = Divide(firstNumber, secondNumber);
                    operation = "/";
                }

                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}");
        }
    }


    static void CalculatorMenu()
    {
        Console.WriteLine("=== Calculator ===");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("Q. Quit");
        Console.WriteLine("Select your operation:");
    }

    bool IsValidSelection(string selection)
    {
        return selection == "1" || selection == "2" || selection == "3" || selection == "4" ||
               selection.ToUpper() == "Q";
    }

    double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    double Divide(double firstNumber, double secondNumber)
    {
        return firstNumber / secondNumber;
    }
}
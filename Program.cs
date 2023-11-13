Console.WriteLine("Simple Calculator App");
Start();
static void Start()
{
    Console.WriteLine("Would you like to solve a math problem? Yes or No");
    string input = Console.ReadLine().ToLower();
    if (input == "yes")
    {
        do
        {
            int equals;
            Console.WriteLine("Enter your first number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition (+), Subtraction (-), Multiplication(*), Division (/)");
            string? problemType = Console.ReadLine();
            Console.WriteLine("Enter the second number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            switch (problemType)
            {
                case "+":
                    {
                        equals = firstNumber + secondNumber;
                        Console.WriteLine($"{equals}");
                        break;
                    }
                case "-":
                    {
                        equals = firstNumber - secondNumber;
                        Console.WriteLine($"{equals}");
                        break;
                    }
                case "*":
                    {
                        equals = firstNumber * secondNumber;
                        Console.WriteLine($"{equals}");
                        break;
                    }
                case "/":
                    {
                        equals = firstNumber / secondNumber;
                        Console.WriteLine($"{equals}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid problem.");
                        break;
                    }
            }
            Console.WriteLine("Start over? Yes or No");
            string? answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Start();
                break;
            }
            else if (answer == "no")
            {
                Console.WriteLine("Press Enter to exit.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadKey();
            }
        } while (input == "yes");
    }
    else if (input == "no")
    {
        Console.WriteLine("Press enter to exit.");
        Console.ReadLine();
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid entry.");
        Start();
    }
}
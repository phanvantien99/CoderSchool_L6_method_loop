namespace Methods_and_Loops_q1;

class Program
{
    static void Main(string[] args)
    {
        FibonacciSequence(7);
    }
    //---------------------------------------------------------------------
    // Part 1: Displaying a Welcome Message
    // Create a user-defined function to display a welcome message.
    // Hint: Define a function named DisplayWelcomeMessage() that prints the welcome message to the console.
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome!!");
    }
    //---------------------------------------------------------------------
    // Part 2: Personalized Welcome Message
    // Create a user-defined function with parameters to personalize a welcome message.
    // Hint: Define a function named PersonalizedWelcomeMessage() that takes a name as a parameter and prints a personalized welcome message to the console.
    static void DisplayWelcomeMessageName(string name)
    {
        Console.WriteLine("Welcome " + name);
    }
    //---------------------------------------------------------------------
    // Part 3: Calculating the Sum of Two Numbers
    // Create a user-defined function to calculate the sum of two numbers.
    // Hint: Define a function named CalculateSum() that takes two parameters, adds them, and returns the result.
    static void SumOfTwoNumber(int number1, int number2)
    {
        Console.WriteLine("Sum: " + (number1 + number2));
    }
    //---------------------------------------------------------------------
    // Part 4: Counting Spaces in a String
    // Create a user-defined function to count the number of spaces in a string.
    // Hint: Define a function named CountSpaces() that takes a string as a parameter, counts the number of spaces, and returns the count.
    static void CountSpace(string s)
    {
        int count = s.Count(character => character == ' ');
        Console.Write("Count space: " + count);
    }
    //---------------------------------------------------------------------
    // Part 5: Calculating the Sum of Elements in an Array
    // Create a user-defined function to calculate the sum of elements in an array.
    // Hint: Define a function named CalculateArraySum() that takes an array as a parameter, calculates the sum of its elements, and returns the sum.
    static void CalculateSumOfArray(int[] ints)
    {
        int sum = ints.Aggregate(0, (acc, x) => acc + x);
        Console.Write("Sum of arrays: " + sum);
    }
    //---------------------------------------------------------------------
    // Part 6: Swapping Two Integer Numbers
    // Create a user-defined function to swap two integer numbers.
    // Hint: Define a function named SwapNumbers() that takes two integer parameters, swaps their values, and prints the updated values to the console.
    static void SwapInteger(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
        Console.Write("a: " + a + " b: " + b);
    }
    //---------------------------------------------------------------------
    // Part 7: Calculating Exponentiation
    // Create a user-defined function to calculate the result of raising an integer number to another.
    // Hint: Define a function named CalculateExponent() that takes two integer parameters (base and exponent), calculates the result, and prints it to the console.
    static void CalculatingExponentiation(int numb, int pow)
    {
        Console.WriteLine(Math.Pow(numb, pow));
    }

    //---------------------------------------------------------------------
    // Part 8: Displaying the Fibonacci Sequence
    // Create a user-defined function to display the Fibonacci sequence up to a specified number of terms.
    // Hint: Define a function named DisplayFibonacciSequence() that takes an integer parameter (number of terms), calculates and prints the Fibonacci sequence to the console.
    static void FibonacciSequence(int number)
    {
        int first = 0;
        int second = 1;
        Console.Write(first + " ");
        Console.Write(second + " ");
        for (int i = 0; i < number - 2; i++)
        {
            int newNumb = first + second;
            Console.Write(newNumb + " ");
            first = second;
            second = newNumb;
        }
    }
    //---------------------------------------------------------------------
    // Part 9: Checking Prime Numbers
    // Create a user-defined function to check whether a number is prime or not.
    // Hint: Define a function named CheckPrimeNumber() that takes an integer parameter, checks if it's prime, and prints the result to the console.
    static void CheckPrimeNumber(int number)
    {
        if (number <= 1)
        {
            Console.WriteLine($"{number} is not a prime number.");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }
        }

        Console.WriteLine($"{number} is a prime number.");
    }

    //---------------------------------------------------------------------
    // Part 10: Calculating the Sum of Individual Digits
    // Create a user-defined function to calculate the sum of individual digits of a given number.
    // Hint: Define a function named CalculateDigitSum() that takes an integer parameter, calculates the sum of its digits, and prints the result to the console.
    static void CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"The sum of the digits is: {sum}");
    }

    //---------------------------------------------------------------------
    // Part 11: Testing Named Parameters in C#
    // Write a C# program that defines a method called "DisplayInfo" that takes two parameters: "name" and "age".
    // Use named parameters to call the "DisplayInfo" method with the parameter values "name"="John" and "age"=30.
    // Hint: Define the method "DisplayInfo" with parameters "name" and "age", then call it using named parameters.
    static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    //---------------------------------------------------------------------
    // Part 12: Testing Out Parameters in C#
    // Write a C# program that defines a method called "GetSquareRoot" that calculates the square root of a number.
    // Use an out parameter to return the square root of a given number.
    // Hint: Define the method "GetSquareRoot" with an out parameter to store the result.
    static void GetSquareRoot(double number, out double result)
    {
        result = Math.Sqrt(number);
    }

    //---------------------------------------------------------------------
    // Part 13: Testing Default or Optional Parameters in C#
    // Write a C# program that defines a method called "GreetUser" with two parameters: "name" and "greetingMessage".
    // Set the default value of "greetingMessage" to "Hello".
    // Call the "GreetUser" method with only the "name" parameter provided.
    // Hint: Define the method "GreetUser" with a default value for one of its parameters.
    public static void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine($"{greetingMessage}, {name}!");
    }
}

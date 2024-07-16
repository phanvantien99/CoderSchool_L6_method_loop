namespace Method_and_Loops_q2;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
    }

    // part 1
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to our application!");
    }

    // part 2
    public static void PersonalizedWelcomeMessage(string name)
    {
        Console.WriteLine($"Welcome, {name}!");
    }

    // part 3
    public static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    // part 4
    public static int CountSpaces(string input)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == ' ')
                count++;
        }
        return count;
    }

    // part 5
    public static int CalculateArraySum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    // part 6
    public static void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // part 7
    public static void CalculateExponent(int baseNum, int exponent)
    {
        int result = (int)Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
    }

    // part 8
    public static void DisplayFibonacciSequence(int terms)
    {
        int a = 0, b = 1, next;
        for (int i = 0; i < terms; i++)
        {
            Console.Write(a + " ");
            next = a + b;
            a = b;
            b = next;
        }
    }

    // part 9
    public static void CheckPrimeNumber(int number)
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

    // part 10
    public static void CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"The sum of the digits is: {sum}");
    }

    // part 11
    public static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    // part 12
    public static void GetSquareRoot(double number, out double result)
    {
        result = Math.Sqrt(number);
    }

    // part 13
    public static void GreetUser(string name, string greetingMessage = "Hello")
    {
        Console.WriteLine($"{greetingMessage}, {name}!");
    }

}

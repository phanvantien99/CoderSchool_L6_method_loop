namespace Method_and_Loops_q3;

class Program
{
    static void Main(string[] args)
    {
        SequenceNumber();
    }

    // part 1
    public static void SequenceNumber()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
    }

    // part 2
    public static void CubeOfNumber()
    {
        Console.Write("Input number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        for (int i = 1; i <= terms; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"Number is: {i} and cube of the {i} is: {cube}");
        }
    }

    // part 3
    public static void MultiplicationTable()
    {
        Console.Write("Input the number (Table to be calculated): ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int product = number * i;
            Console.WriteLine($"{number} X {i} = {product}");
        }
    }

    // part 4
    public static void AlphabetPattern()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j == i || j == 6 - i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j == 3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    //part 5
    public static void HealthRegeneration()
    {
        int health = 0;

        for (int round = 1; round <= 5; round++)
        {
            health += 10;
            Console.WriteLine($"Round {round}: Health {health}");
        }
    }

    //part 6
    public static void ListOfName()
    {
        List<string> names = new List<string> { "John", "James", "Luke", "Lila" };

        foreach (string name in names)
        {
            Console.WriteLine($"Name: {name}");
        }
    }

    // part 7
    public static void SqaureOfNUmber()
    {
        List<int> numbers = new List<int> { 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            int square = number * number;
            Console.WriteLine($"Square of {number}: {square}");
        }
    }
}
